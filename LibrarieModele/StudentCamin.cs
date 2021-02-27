//Beilic Maria 3122B
using System;
using System.Collections;
namespace LibrarieModele
{
    public class StudentCamin
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const int BonusAn1 = 50;
        private const int BonusAn2 = 25;
        private const int BonusAn3 = 10;
        private const int BonusAn4 = 5;

        //data membra privata
        int AnUniversitar;

        //proprietati auto-implemented       
        public int IdStudent { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Distanta { get; set; }
        public int Camera { set; get; }
        public DateTime DataActualizata { set; get; }
        public OptiuniFacultate ProgramSTD { get; set; }
        public Studii StudSTD { get; set; }
        public string NumeComplet { get { return Nume + " " + Prenume; } }
        public int AnFacultate { get { return AnUniversitar; } }
        public ArrayList Camine { get; set; }

        public string CamineAsString
        {
            get
            {
                string sCamine = string.Empty;

                foreach (string camin in Camine)
                {
                    if (sCamine != string.Empty)
                    {
                        sCamine += SEPARATOR_SECUNDAR_FISIER;
                    }
                    sCamine += camin;
                }

                return sCamine;
            }
        }

        #region _Constructori_
        //contructor implicit
        public StudentCamin()
        {
            Nume = Prenume = string.Empty;
            Distanta = 0;
            AnUniversitar = 0;
            DataActualizata = DateTime.Now;
            
        }

        //constructor1 cu parametri
        public StudentCamin(string _nume, string _prenume, int _distanta, int _anUniversitar)
        {
            Nume = _nume;
            Prenume = _prenume;
            Distanta = _distanta;
            AnUniversitar = _anUniversitar;
            DataActualizata = DateTime.Now;

        }




        //constructor3 cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public StudentCamin(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ToString()
            IdStudent = Convert.ToInt32(dateFisier[(int)CampuriStudent.ID]);
            Nume = dateFisier[(int)CampuriStudent.NUME];
            Prenume = dateFisier[(int)CampuriStudent.PRENUME];
            Distanta = Convert.ToInt32(dateFisier[(int)CampuriStudent.DISTANTA]);
            AnUniversitar = Convert.ToInt32(dateFisier[(int)CampuriStudent.AN]);
            ProgramSTD = (OptiuniFacultate)Enum.Parse(typeof(OptiuniFacultate), dateFisier[(int)CampuriStudent.OPTIUNIFACULTATE]);
            Camine = new ArrayList();
            Camine.AddRange(dateFisier[(int)CampuriStudent.CAMINE].Split(SEPARATOR_SECUNDAR_FISIER));
            Camera = Convert.ToInt32(dateFisier[(int)CampuriStudent.CAMERA]);
            DataActualizata = Convert.ToDateTime(dateFisier[(int)CampuriStudent.DATA]);
            StudSTD = (Studii)Enum.Parse(typeof(Studii), dateFisier[(int)CampuriStudent.STUDII]);


        }
        public void GetAn( string An)
        {
            bool rezultat = Int32.TryParse(An, out  AnUniversitar);
        }
      
        //proprietate punctaj cazare
        public string Punctaj()
        {
            string sir1;
            int punctaj=0;
            if(Distanta>=30)
            {
                for(int i=Distanta;i>=30;i--)
                {
                    punctaj += 1;
                }
                if (AnUniversitar == 1)
                    punctaj += BonusAn1;
                else if (AnUniversitar == 2)
                    punctaj += BonusAn2;
                else if (AnUniversitar == 3)
                    punctaj += BonusAn3;
                else if (AnUniversitar == 4)
                    punctaj += BonusAn4;
            }
            if(punctaj!=0)
            {
                sir1 = string.Format("Studentul cu punctajul {0} asigura conditiile necesare cazarii in caminele USV!",punctaj);

            }
            else
            {
                sir1 = string.Format("Punctaj insuficient!!!"); //fara format

            }
            return sir1;

        }
        #endregion


        //utilizare metoda statica din clasa statica

        public string ConversieLaSir()
        {
            string sir1;
            if (Nume == null || Prenume == null || Distanta == 0 || AnUniversitar == 0)
                sir1 = string.Format("Adaugati un student!");
            else

                sir1 = string.Format("Studentul cu Id: #{0} si numele: \"{1} {2}\" are distanta fata de universitate  {3} km ,{4}, fiind in anul {5}  la facultatea  {6} optiuni camine: {7}, a optat pentru o camera cu  studenti: {8}  ", IdStudent, (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "), Distanta,StudSTD, AnUniversitar, ProgramSTD, CamineAsString,Camera);
            return sir1;
        }

        //conversie la sir pentru fisier
        public string ConversieLaSir_PentruFisier()
        {


            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}",
                SEPARATOR_PRINCIPAL_FISIER, IdStudent.ToString(), (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "), Distanta, AnUniversitar, ProgramSTD,CamineAsString,Camera,DataActualizata,StudSTD);

            return s;
        }
    }
}
