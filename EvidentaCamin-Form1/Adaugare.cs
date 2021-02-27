//Beilic Maria 3122B
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;
using System.Collections.Generic;

namespace EvidentaCamin_Form1
{
    public partial class USVCazareStudenti : Form
    {
        private const int LUNGIME_MAX = 20;
        private const int AnMin = 1;
        private const int AnMax = 4;
        IStocareData adminStudenti;
        ArrayList camineSelectate = new ArrayList();
        public USVCazareStudenti()
        {
            InitializeComponent();
            adminStudenti = StocareFactory.GetAdministratorStocare();
            ResetareControale();
        }

        private void BtnAdauga_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();
            CodEroare codValidare = Validare(txtNume.Text, txtPrenume.Text, txtDistanta.Text, txtAnUniversitar.Text);
            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
                MessageBox.Show("Trebuie sa verificati datele marcate cu rosu! Informatia lipseste sau a fost introdusa incorect.");
            }
            else
            {
                StudentCamin s = new StudentCamin(txtNume.Text, txtPrenume.Text, Convert.ToInt32(txtDistanta.Text), Convert.ToInt32(txtAnUniversitar.Text));

                
                s.ProgramSTD = GetSelectetFacultate();
                s.StudSTD = GetSelectedStudii();
                //set Discipline
                s.Camine = new ArrayList();
                s.Camine.AddRange(camineSelectate);
                s.Camera = Convert.ToInt32(cmbCamera.Text);

                adminStudenti.AddStudent(s);
                lblAdauga.Text = "Studentul a fost adaugat";

                //resetarea controalelor pentru a introduce datele unui student nou
                ResetareControale();

            }
        }


        private void ResetCuloareEtichete()
        {
            lblNume.ForeColor = Color.Black;
            lblPrenume.ForeColor = Color.Black;
            lblDistanta.ForeColor = Color.Black;
            lblAnUniversitar.ForeColor = Color.Black;
            lblFacultate.ForeColor = Color.Black;
            lblCamine.ForeColor = Color.Black;
            lblCamera.ForeColor = Color.Black;
            lblStudii.ForeColor = Color.Black;
        }

        private CodEroare Validare(string nume, string prenume, string distanta, string an)
        {
            CodEroare rezultatValidare = CodEroare.CORECT;
            if (nume == string.Empty || nume.Length>LUNGIME_MAX)
            {
                rezultatValidare |= CodEroare.NUME_INCORECT;
            }
            if (prenume == string.Empty)
            {
                rezultatValidare |= CodEroare.PRENUME_INCORECT;
            }
            if (distanta == string.Empty ||Convert.ToInt32(distanta)<0)
            {
                rezultatValidare |= CodEroare.DISTANTA_INCORECTA;
            }
            if (an == string.Empty || Convert.ToInt32(an)<AnMin || Convert.ToInt32(an) > AnMax)
            {
                rezultatValidare |= CodEroare.AN_INCORECT;
            }
            // verificare ca este cel putin un program studiu selectat
            int FacultateSelectata = 0;
            foreach (var control in gpbFacultate.Controls)
            {
                RadioButton rdb = null;
                try
                {
                    rdb = (RadioButton)control;
                }
                catch { }

                if (rdb != null && rdb.Checked == true)
                    FacultateSelectata = 1;
            }
            if (FacultateSelectata == 0)
                rezultatValidare |= CodEroare.FACULTATE_INCORECTA;


            if(ckbCamin1.Checked==false && ckbCamin2.Checked==false && ckbCamin3.Checked==false &&ckbCamin4.Checked==false &&ckbCamin5.Checked==false &&ckbCamin8.Checked==false)
            {
                rezultatValidare |= CodEroare.CAMIN_INCORECT;

            }
            if(cmbCamera.Text==string.Empty)
            {
                rezultatValidare |= CodEroare.CAMERA_INCORECTA;
            }

            int StudSelectat = 0;
            foreach (var control in gpbStudii.Controls)
            {
                RadioButton rdb1 = null;
                try
                {
                    rdb1 = (RadioButton)control;
                }
                catch { }

                if (rdb1 != null && rdb1.Checked == true)
                    StudSelectat = 1;
            }
            if (StudSelectat == 0)
                rezultatValidare |= CodEroare.STUD_INCORECT;

            return rezultatValidare;


        }

        private void BtnAfisare_Click(object sender, EventArgs e)
        {
            lBoxAfisare.Items.Clear();
            var antetTabel = String.Format("{0,-5}{1,-35}{2,20}{3,10}\n", "Id", "Nume Prenume", "Distanta", "Facultate");
            lBoxAfisare.Items.Add(antetTabel);

            List<StudentCamin> studenti = adminStudenti.GetStudenti();
            foreach (StudentCamin s in studenti)
            {
                var linieTabel = String.Format("{0,-5}{1,-35}{2,20}{3,10}\n", s.IdStudent, s.NumeComplet, s.Distanta, s.ProgramSTD.ToString());
                lBoxAfisare.Items.Add(linieTabel);
            }
        }





        private void BtnCazare_Click(object sender, EventArgs e)
        {
            CodEroare codValidare = Validare(txtNume.Text, txtPrenume.Text, txtDistanta.Text, txtAnUniversitar.Text);
            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
                MessageBox.Show("Selectati un student din lista!");
            }
            else
            {
                StudentCamin s = new StudentCamin(txtNume.Text, txtPrenume.Text, Convert.ToInt32(txtDistanta.Text), Convert.ToInt32(txtAnUniversitar.Text));
                lblCazare.Text = s.Punctaj();
                ResetareControale();
                ResetCuloareEtichete();
            }
        }

        private void btnDeconectare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin n = new Admin();
            n.Show();
        }



        private OptiuniFacultate GetSelectetFacultate()
        {
            if (rdbFiesc.Checked)
                return OptiuniFacultate.FIESC;
            if (rdbFdsa.Checked)
                return OptiuniFacultate.FDSA;
            if (rdbFefs.Checked)
                return OptiuniFacultate.FEFS;
            if (RdbFia.Checked)
                return OptiuniFacultate.FIA;
            if (rdbFimmm.Checked)
                return OptiuniFacultate.FIMMM;
            if (rdbFig.Checked)
                return OptiuniFacultate.FIG;
            if (rdbFLSC.Checked)
                return OptiuniFacultate.FLSC;
            if (rdbFS.Checked)
                return OptiuniFacultate.FS;
            if (rdbFse.Checked)
                return OptiuniFacultate.FSE;
            if (rdbFseap.Checked)
                return OptiuniFacultate.FSEAP;

            return OptiuniFacultate.Neselectat;

        }
        private Studii GetSelectedStudii()
        {
            if (rdbLicenta.Checked)
                return Studii.Licenta;
            if (rdbMaster.Checked)
                return Studii.Masterat;
            if (rdbDosctorat.Checked)
                return Studii.Doctorat;
            return Studii.Neselectata;
        }


        private void ckbCamine_CheckedChanged(object sender, EventArgs e)
       {
           CheckBox checkBoxControl = sender as CheckBox;
            //putem folosii si operatorul cast 
            //CheckBox checkBoxControl = (CheckBox)sender;
            string CaminSelectat = checkBoxControl.Text;
            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                camineSelectate.Add(CaminSelectat);
            else
                camineSelectate.Remove(CaminSelectat);
            
        }
        private void ResetareControale()
        {
            txtNume.Text = txtPrenume.Text = txtAnUniversitar.Text = txtDistanta.Text = string.Empty;
            rdbFdsa.Checked = false;
            rdbFefs.Checked = false;
            RdbFia.Checked = false;
            rdbFiesc.Checked = false;
            rdbFig.Checked = false;
            rdbFimmm.Checked = false;
            rdbFLSC.Checked = false;
            rdbFS.Checked = false;
            rdbFse.Checked = false;
            rdbFseap.Checked = false;
            rdbLicenta.Checked = false;
            rdbMaster.Checked = false;
            rdbDosctorat.Checked = false;
            ckbCamin1.Checked = false;
            ckbCamin2.Checked = false;
            ckbCamin3.Checked = false;
            ckbCamin4.Checked = false;
            ckbCamin5.Checked = false;
            ckbCamin8.Checked = false;
            camineSelectate.Clear();
            cmbCamera.Text="";
            

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
            if ((codValidare & CodEroare.DISTANTA_INCORECTA) == CodEroare.DISTANTA_INCORECTA)
            {
                lblDistanta.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.AN_INCORECT) == CodEroare.AN_INCORECT)
            {
                lblAnUniversitar.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.FACULTATE_INCORECTA) == CodEroare.FACULTATE_INCORECTA)
            {
                lblFacultate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.CAMIN_INCORECT) == CodEroare.CAMIN_INCORECT)
            {
                lblCamine.ForeColor = Color.Red;
            }
            if((codValidare & CodEroare.CAMERA_INCORECTA)==CodEroare.CAMERA_INCORECTA)
            {
                lblCamera.ForeColor = Color.Red;
            }
            if((codValidare & CodEroare.STUD_INCORECT)==CodEroare.STUD_INCORECT)
            {
                lblStudii.ForeColor = Color.Red;
            }
        }

        private void lBoxAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentCamin s = adminStudenti.GetStudent(lBoxAfisare.SelectedIndex);

            if (s != null)
            {
                
                
                txtNume.Text = s.Nume;
                txtPrenume.Text = s.Prenume;
                txtDistanta.Text = Convert.ToString(s.Distanta);
                txtAnUniversitar.Text = Convert.ToString(s.AnFacultate);
                foreach (var camin in gpbCamine.Controls)
                {
                    if (camin is CheckBox)
                    {
                        var camineBOx = camin as CheckBox;
                        foreach (String dis in s.Camine)
                            if (camineBOx.Text.Equals(dis))
                            {
                                camineBOx.Checked = true;
                            }
                            else
                            {
                                camineBOx.Checked = false;
                            }
                    }
                }
                foreach (var programStud in gpbFacultate.Controls)
                {
                    if (programStud is RadioButton)
                    {
                        var programStudBox = programStud as RadioButton;

                        if (programStudBox.Text.Equals(s.ProgramSTD.ToString()))
                            programStudBox.Checked = true;
                    }
                }
                foreach (var studiiStud in gpbStudii.Controls)
                {
                    if (studiiStud is RadioButton)
                    {
                        var studiiStudBox = studiiStud as RadioButton;

                        if (studiiStudBox.Text.Equals(s.StudSTD.ToString()))
                            {
                            studiiStudBox.Checked = true;
                            }
                    }
                }
                cmbCamera.Text = s.Camera.ToString();
                ResetCuloareEtichete();

            }
        }

        private void txtDistanta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )            
                e.Handled = true;
            
        }

        private void txtPrenume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;


        }

       
    }
    }




            

    

  

