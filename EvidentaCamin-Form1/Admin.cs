//Beilic Maria 3122B
using System;
using System.Windows.Forms;

namespace EvidentaCamin_Form1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnInregistreaza_Click(object sender, EventArgs e)
        {
            this.Hide();
            USVCazareStudenti a = new USVCazareStudenti();
            a.Show();
        }

        private void BtnCautare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modificare m = new Modificare();
            m.Show();
        }

        private void btnDeconectare_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm n = new LoginForm();
            n.Show();
        }

        
    }
}
