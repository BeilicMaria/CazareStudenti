//Beilic Maria 3122B
using System;
using System.Windows.Forms;

namespace EvidentaCamin_Form1
{
    public partial class LoginForm : Form
    {
        bool contor = true;
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void btlLogin_Click(object sender, EventArgs e)
        {
            string id = txtUser.Text;
            string pass = txtPassword.Text;
            if (id == "admin" && pass == "2020")
            {
                this.Hide();
                Admin ba = new Admin();
                ba.Show();
            }
            if (id == "maria" && pass == "student2020")
            {
                this.Hide();
                Utilizator na = new Utilizator();
                na.Show();
            }
            if (id != "admin" && id != "maria" || pass != "2020" && pass != "student2020")
            {
                if (contor == true)
                {
                    MessageBox.Show("Date incorecte!");
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");
                }

            }
        }


        private void btnreset_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
        }

        private void btnLimbaEngleza_Click(object sender, EventArgs e)
        {
            lblUser.Text = "Username:";
            lblPassword.Text = "Password:";
            btlLogin.Text = "Register";
            btnreset.Text = "Reset";
            btnExit.Text = "Exit";
            contor = false;

        }

        private void btnLimbaRomana_Click(object sender, EventArgs e)
        {
            lblUser.Text = "Utilizator:";
            lblPassword.Text = "Parola:";
            btlLogin.Text = "Conectare";
            btnreset.Text = "Resetare";
            btnExit.Text = "Ieșire";
            contor = true;
        }
       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}


