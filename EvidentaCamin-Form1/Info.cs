//Beilic Maria 3122B
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EvidentaCamin_Form1
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            Ascundelbl();
        }

        private void cmbCamin_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aratalbl();
           
            if (cmbCamin.Text == "C1")
            {

                pcBCamin.Image = Image.FromFile(@"C:\Users\beili\OneDrive\Desktop\Facultate\Anul II(2019-2020)\Semestrul II\PIU\PIU Proiect Laborator\Proiect PIU\c1.png");
                txtAdresa.Text = "Str. Universităţii nr. 13";
                txtZona.Text = "Campus";
                txtAdministrator.Text = "Carmen Urzică";
                txtTelefon.Text = "0230/216147 interior 269";
                txtTip.Text = "fete";
                txtCapacitate.Text = "108 locuri (27 camere)";
                txtTarif.Text = "151 – 331 lei";
                rtbDotari.Text = "Cameră cu 4 locuri.  Paturi supraetajate. Saltea Relaxa. Lenjerie de pat. Mobilier compus din: pat, dulap, masă, scaun. Frigider. Internet. Oficiu de preparare a hranei dotat cu plite electrice. Spălătorie utilată corespunzător la parter. Grupuri sanitare și dușuri comune la fiecare etaj.";
            }
            if (cmbCamin.Text == "C2")
            {
                pcBCamin.Image = Image.FromFile(@"C:\Users\beili\OneDrive\Desktop\Facultate\Anul II(2019-2020)\Semestrul II\PIU\PIU Proiect Laborator\Proiect PIU\c2.png");
                txtAdresa.Text = "Str. Universităţii nr. 13";
                txtZona.Text = "Campus";
                txtAdministrator.Text = "Florin Ilişoi";
                txtTelefon.Text = "0230/216147 interior 279";
                txtTip.Text = "băieți";
                txtCapacitate.Text = "337 locuri (110 camere cu 3/4 locuri)";
                txtTarif.Text = "201 - 391 lei";
                rtbDotari.Text = "Cameră cu 3 sau 4 locuri. Grup sanitar și duș în cameră. Pat simplu sau supraetajat. Saltea Relaxa. Lenjerie de pat. Televizor color. Frigider. Internet și TV prin cablu. Mobilier compus din: pat, dulap, birou, etajeră, corp cu rafturi, scaun. 8 oficii de preparare a hranei dotate cu plite electrice. Spălătorie utilată corespunzător la demisol.";
            }
            if (cmbCamin.Text == "C3")
            {
                pcBCamin.Image = Image.FromFile(@"C:\Users\beili\OneDrive\Desktop\Facultate\Anul II(2019-2020)\Semestrul II\PIU\PIU Proiect Laborator\Proiect PIU\c3.png");
                txtAdresa.Text = "Str. Mihai Viteazul nr. 20A";
                txtZona.Text = "Centru";
                txtAdministrator.Text = "Carmen Urzică";
                txtTelefon.Text = "0230/216147 interior 269";
                txtTip.Text = "mixt";
                txtCapacitate.Text = "176 locuri (88 camere)";
                txtTarif.Text = "221 - 411 lei";
                rtbDotari.Text = "Cameră cu 2 locuri. Grup sanitar și duș în cameră. Saltea Relaxa. Lenjerie de pat. Televizor color. Frigider. Internet și TV prin cablu. Mobilier compus din: pat, dulap, birou, bibliotecă, comodă TV, scaun. 5 oficii de preparare a hranei dotate cu plite electrice și hote. Spălătorie utilată corespunzător la parter..";
            }
            if (cmbCamin.Text == "C4")
            {
                pcBCamin.Image = Image.FromFile(@"C:\Users\beili\OneDrive\Desktop\Facultate\Anul II(2019-2020)\Semestrul II\PIU\PIU Proiect Laborator\Proiect PIU\c4.png");
                txtAdresa.Text = "Str.  Scurtă nr. 6";
                txtZona.Text = "Campus";
                txtAdministrator.Text = "Ana-Maria Babi";
                txtTelefon.Text = "0230/216147 interior 450";
                txtTip.Text = "mixt";
                txtCapacitate.Text = "302 locuri ";
                txtTarif.Text = "221 - 411 lei";
                rtbDotari.Text = "Cameră cu 2 locuri. Grup sanitar și duș în cameră. Saltea Relaxa. Lenjerie de pat. Televizor color. Frigider. Internet și TV prin cablu. Mobilier compus din: pat simplu sau supraetajat, dulap, masă, birou, etajeră de colț, bibliotecă, comodă TV, scaun. 5 oficii de preparare a hranei dotate cu plite electrice și hote. Spălătorie utilată corespunzător la demisol.";
            }
            if (cmbCamin.Text == "C5")
            {
                pcBCamin.Image = Image.FromFile(@"C:\Users\beili\OneDrive\Desktop\Facultate\Anul II(2019-2020)\Semestrul II\PIU\PIU Proiect Laborator\Proiect PIU\c5.png");
                txtAdresa.Text = "Str. Universității nr. 36A";
                txtZona.Text = "Vis-a-vis Campus";
                txtAdministrator.Text = "Daniel Buzdugan";
                txtTelefon.Text = "230/216147 interior 352";
                txtTip.Text = "mixt";
                txtCapacitate.Text = "42 locuri (21 camere)";
                txtTarif.Text = "231 - 421 lei";
                rtbDotari.Text = "Cameră cu 2 locuri. Grup sanitar și duș în cameră. Saltea Relaxa. Lenjerie de pat. Internet si TV prin cablu. Mobilier compus din: pat, dulap, birou, noptieră, corp etajat, scaun. Televizor color. Frigider.";
            }
            if (cmbCamin.Text == "C8")
            {
                pcBCamin.Image = Image.FromFile(@"C:\Users\beili\OneDrive\Desktop\Facultate\Anul II(2019-2020)\Semestrul II\PIU\PIU Proiect Laborator\Proiect PIU\c8.png");
                txtAdresa.Text = "Str. Narciselor nr. 22";
                txtZona.Text = "";
                txtAdministrator.Text = "Daniel Buzdugan";
                txtTelefon.Text = "0230/216147 interior 352";
                txtTip.Text = "mixt";
                txtCapacitate.Text = "50 locuri";
                txtTarif.Text = "231 - 450 lei";
                rtbDotari.Text = "Cameră cu 2 locuri. Grup sanitar și duș în cameră. Saltea Relaxa. Lenjerie de pat. Internet si TV prin cablu. Mobilier compus din: pat, dulap, birou, noptieră, corp etajat, scaun tip fotoliu. Televizor color. Frigider. 1 oficiu de preparare a hranei dotat cu plite electrice și hote. Spălătorie utilată corespunzător la demisol.";
            }

        }
        private void Aratalbl()
        {
            lblAdministrator.Show();
            lblAdresa.Show();          
            lblCapacitate.Show();
            lblDotari.Show();
            lblTarif.Show();
            lblTelefon.Show();
            lblTip.Show();
            lblZona.Show();
        }
        private void Ascundelbl()
        {
            lblAdministrator.Hide();
            lblAdresa.Hide();          
            lblCapacitate.Hide();
            lblDotari.Hide();
            lblTarif.Hide();
            lblTelefon.Hide();
            lblTip.Hide();
            lblZona.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
