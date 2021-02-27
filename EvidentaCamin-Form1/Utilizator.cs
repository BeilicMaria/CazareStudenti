//Beilic Maria 3122B
using System;
using System.Windows.Forms;

namespace EvidentaCamin_Form1
{
    public partial class Utilizator : Form
    {
        private Form formaActiva = null;
        public Utilizator()
        {
            InitializeComponent();
        }

        private void btnLimbaEngleza_Click(object sender, EventArgs e)
        {
           
            btnDeconectare.Text = "Sign out";
            btnInfo.Text = "Info";
            btnLista.Text = "List of students";
        }

        private void btnLimbaRomana_Click(object sender, EventArgs e)
        {
           
            btnDeconectare.Text = "Deconectare";
            btnInfo.Text = "Informații";
            btnLista.Text = "Listă Studenți";
        }

        //metoda care deschide forma dorita in panelChildForm (o singura forma in panou)
        private void deschideChildForm( Form childForm)
        {
            //inchidem  forma precedenta
            if (formaActiva != null)
                formaActiva.Close();
            //salvam forma care se va deschide in variabila formaActiva
            formaActiva = childForm;
            childForm.TopLevel = false; //se va comporta ca un control
            childForm.FormBorderStyle = FormBorderStyle.None; //eliminam bordura formei
            childForm.Dock = DockStyle.Fill; //umple spatiul panoului complet cu forma dorita 
            panelChildForl.Controls.Add(childForm); //adugam forma in lista de controle a panoului
            panelChildForl.Tag = childForm; //asociere a formei cu panoul 
            childForm.BringToFront(); 
            childForm.Show();
        }

        private void btnDeconectare_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                LoginForm n = new LoginForm();
                n.Show();   
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            deschideChildForm(new Lista());       
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            deschideChildForm(new Info());
        }
    }
}
