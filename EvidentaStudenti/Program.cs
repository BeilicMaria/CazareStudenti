using System;
using LibrarieModele;
using NivelAccesDate;
using System.Collections;

namespace EvidentaStudenti
{
    class Program
    {
        static void Main()
        {
            //variabila de tip interfata 'IStocareData' care este initializata 
            //cu o instanta a clasei 'AdministrareStudenti_FisierText' sau o instanta a clasei 'AdministrareStudenti_FisierBinar' in functie de setarea 'FormatSalvare' din fisierul AppConfig
            IStocareData adminStudenti = StocareFactory.GetAdministratorStocare();

            string optiune;
            do
            {
                Console.WriteLine("L. Listare studenti");
                Console.WriteLine("A. Adaugare student");
                Console.WriteLine("C. Cauta student");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                Console.Clear();
                switch (optiune.ToUpper())
                {
                    case "L":
                        ArrayList studenti = adminStudenti.GetStudenti();
                        if (studenti.Count > 0)
                        {
                            StudentCamin.IdUltimStudent = ((StudentCamin)studenti[studenti.Count - 1]).IdStudent;
                        }

                        AfisareStudenti(studenti);
                        break;
                    case "A":
                        StudentCamin stud_tastatura = CitireStudentTastatura();
                        //adaugare student in fisier
                        adminStudenti.AddStudent(stud_tastatura);
                        break;
                    case "C":
                        //cautare
                        Console.WriteLine("Introduceti nume persoana cautata:");
                        string Nume_temporar = Console.ReadLine();
                        Console.WriteLine("Introduceti prenume persoana cautata:");
                        string Prenume_temporar = Console.ReadLine();
                        StudentCamin stud_cautat = adminStudenti.GetStudent(Nume_temporar, Prenume_temporar);
                        if (stud_cautat != null)
                        {
                            Console.WriteLine("Studentul cautat este: {0}", stud_cautat.ConversieLaSir());

                        }

                        //actualizare
                        Console.WriteLine("Introduceti anul universitar:");
                        string an = Console.ReadLine();
                        stud_cautat.AnUniversitar = Convert.ToInt32(an);
                        adminStudenti.UpdateStudent(stud_cautat);
                        break;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }


        public static void AfisareStudenti(ArrayList studenti)
        {
            Console.WriteLine("Studentii sunt:");
            foreach (StudentCamin stud in studenti)
            {
                Console.WriteLine(stud.ConversieLaSir());
            }
        }
        public static StudentCamin CitireStudentTastatura()
        {
            Console.WriteLine("Introduceti numele");
            string nume = Console.ReadLine();
            Console.WriteLine("Introduceti prenumele");
            string prenume = Console.ReadLine();
            Console.WriteLine("Introduceti distanta");
            string distanta = Console.ReadLine();
            Console.WriteLine("Introduceti anul universitar");
            string an = Console.ReadLine();
            StudentCamin s = new StudentCamin(nume, prenume, Convert.ToInt32(distanta), Convert.ToInt32(an));
            Console.WriteLine("Dati facultatea: \n 1.FIESC \n 2.FDSA \n 3. FEFS\n 4.FIA \n 5.FIMMM \n 6.FIG  \n 7.FLSC \n 8.FS \n 9.FSE \n 10.FSEAP");
            s.ProgramSTD = (OptiuniFacultate)Int32.Parse(Console.ReadLine());
            Console.Clear();
            return s;
        }

    }

}
