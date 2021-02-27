//Beilic Maria 3122B
using LibrarieModele;
using System;
using System.Collections.Generic;
using NivelAccesDate;
using System.Windows.Forms;

namespace EvidentaCamin_Form1
{
    public partial class Lista : Form
    {
        IStocareData adminStudenti;
        public Lista()
        {
            InitializeComponent();
            adminStudenti = StocareFactory.GetAdministratorStocare();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            lstAfisareStud.Items.Clear();
            var antetTabel = String.Format("{0,-5}{1,-35}{2,20}\n", "Id", "Nume Prenume", "Facultate");
            lstAfisareStud.Items.Add(antetTabel);

            List<StudentCamin> studenti = adminStudenti.GetStudentiCazati();
            foreach (StudentCamin s in studenti)
            {
                var linieTabel1 = "\n";
                var linieTabel2 = String.Format("{0,-5}{1,-35}{2,20}\n", s.IdStudent, s.NumeComplet,  s.ProgramSTD.ToString());
                lstAfisareStud.Items.Add(linieTabel1);
                lstAfisareStud.Items.Add(linieTabel2);
            }
        }
    }
}
