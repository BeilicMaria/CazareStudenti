//Beilic Maria 3122B
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;

namespace EvidentaCamin_Form1
{
    public partial class Modificare : Form
    {
        int contorcautare = 0;
        IStocareData adminStudenti;
        public Modificare()
        {
            InitializeComponent();
            adminStudenti = StocareFactory.GetAdministratorStocare();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin m = new Admin();
            m.Show();
        }

        private void BtnCautare_Click(object sender, EventArgs e)
        {         
            contorcautare = 1;                    
            CodEroare codValidare = Validare_Cautare(txtNume.Text, txtPrenume.Text);
            ResetCuloareEtichete_Cauta();
            if (codValidare == CodEroare.CORECT)
            {
                StudentCamin s = adminStudenti.GetStudent(txtNume.Text, txtPrenume.Text);
                if (s != null)
                {
                    if (s.Nume == txtNume.Text && s.Prenume == txtPrenume.Text)
                    {
                        lblMesaj.Text = string.Empty;
                        lblMesaj.Text = "Studentul a fost gasit!";
                        List<StudentCamin> stud = adminStudenti.GetStudenti();
                        AdaugaStudentInControlDataGridView(stud);
                    }
                    else
                    {
                        lblMesaj.Text = string.Empty;
                        lblMesaj.Text = "Studentul nu a fost găsit!";
                        dataGridStudent.DataSource = null;
                    }
                    if (txtNume.Enabled == true && txtPrenume.Enabled == true)
                    {
                        txtNume.Enabled = false;
                        txtPrenume.Enabled = false;
                    }
                    else
                    {
                        txtNume.Enabled = true;
                        txtPrenume.Enabled = true;
                    }
                }

                else
                {
                    lblMesaj.Text = string.Empty;
                    lblMesaj.Text = "Studentul nu a fost găsit!";
                } }          
            else
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
                lblMesaj.Text = "Introduceti date valide!";
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (contorcautare == 1)
            {
                ResetCuloareEtichete_Modifica();
                CodEroare codValidare = Validare_Modificare(txtAn.Text);  
                if (codValidare != CodEroare.CORECT)
                {
                    MarcheazaControaleCuDateIncorecte(codValidare);
                    MessageBox.Show("Trebuie sa verificati datele marcate cu rosu!\nInformatia lipseste sau a fost introdusa incorect.");
                }
                else
                {
                    StudentCamin s = adminStudenti.GetStudent(txtNume.Text, txtPrenume.Text);
                    if (s != null)
                    {
                        s.GetAn(txtAn.Text);
                        s.Camera = int.Parse(cmbCamera.Text);
                        s.DataActualizata = DateTime.Now;
                        adminStudenti.UpdateStudent(s);
                        List<StudentCamin> stud = adminStudenti.GetStudenti();
                        AdaugaStudentInControlDataGridView(stud);
                        lblModifica.Text = "Modificare efectuata";
                        txtNume.Enabled = true;
                        txtPrenume.Enabled = true;
                    }
                    else
                    {
                        lblModifica.Text = "Student inexistent!";
                    }
                }
            }
            else
            {
                MessageBox.Show("Trebuie sa cautati un student!");
            }
            ResetareControale();
            contorcautare = 0;
        }


        private void salvareCazati_Click(object sender, EventArgs e)
        {

            List<StudentCamin> studenti_cazati = adminStudenti.GetStudentiCazati();
            saveFile.ShowDialog();
            string numeFisier = saveFile.FileName;

            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
                {
                    foreach (StudentCamin s in studenti_cazati)
                        swFisierText.WriteLine(s.ConversieLaSir());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

        }

        public void AdaugaStudentInControlDataGridView(List<StudentCamin> stud)
        {
            //reset continut control DataGridView
            dataGridStudent.DataSource = null;

            //!!!! Controlul de tip DataGridView are ca sursa de date lista de obiecte de tip Student !!!
            //dataGridStudent.DataSource = stud;
            //personalizare sursa de date
            dataGridStudent.DataSource = stud.Select(s => new { s.Nume, s.Prenume, s.AnFacultate, s.Camera, s.DataActualizata }).ToList();
        }

        private CodEroare Validare_Cautare(string nume, string prenume)
        {
            CodEroare rezultatValidare = CodEroare.CORECT;
            if (nume == string.Empty)
            {
                rezultatValidare |= CodEroare.NUME_INCORECT;
            }
            if (prenume == string.Empty)
            {
                rezultatValidare |= CodEroare.PRENUME_INCORECT;
            }

            return rezultatValidare;


        }
        private void ResetCuloareEtichete_Cauta()
        {
            lblNume.ForeColor = Color.Black;
            lblPrenume.ForeColor = Color.Black;

        }
        private void ResetCuloareEtichete_Modifica()
        {
            lblAn.ForeColor = Color.Black;
            lblCamera.ForeColor = Color.Black;

        }



        private void MarcheazaControaleCuDateIncorecte(CodEroare codValidare)
        {
            if ((codValidare & CodEroare.NUME_INCORECT) == CodEroare.NUME_INCORECT)
            {
                lblNume.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.PRENUME_INCORECT) == CodEroare.PRENUME_INCORECT)
            {
                lblPrenume.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.AN_INCORECT) == CodEroare.AN_INCORECT)
            {
                lblAn.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.CAMERA_INCORECTA) == CodEroare.CAMERA_INCORECTA)
            {
                lblCamera.ForeColor = Color.Red;
            }


        }

        private CodEroare Validare_Modificare(string an)
        {
            CodEroare rezultatValidare = CodEroare.CORECT;
            if (an == string.Empty || Convert.ToInt32(an) > 4 || Convert.ToInt32(an) < 0)
            {
                rezultatValidare |= CodEroare.AN_INCORECT;
            }
            if (cmbCamera.Text == string.Empty)
            {
                rezultatValidare |= CodEroare.CAMERA_INCORECTA;
            }

            return rezultatValidare;

        }
        private void ResetareControale()
        {
            txtNume.Text = txtPrenume.Text = txtAn.Text = string.Empty;
            cmbCamera.SelectedItem = null;


        }

        private void txtNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void txtAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (contorcautare == 1)
            {
               
                    StudentCamin s = adminStudenti.GetStudent(txtNume.Text, txtPrenume.Text);
                    if (s != null)
                    {
                        adminStudenti.DeleteStudent(s);
                        List<StudentCamin> stud = adminStudenti.GetStudenti();
                        AdaugaStudentInControlDataGridView(stud);
                        lblModifica.Text = "Modificare efectuata";
                        txtNume.Enabled = true;
                        txtPrenume.Enabled = true;
                    }
                    else
                    {
                        lblModifica.Text = "Student inexistent!";
                    }                
            }
            else
            {
                MessageBox.Show("Trebuie sa cautati un student!");
            }
            ResetareControale();
            contorcautare = 0;
        }
        
}

 }

