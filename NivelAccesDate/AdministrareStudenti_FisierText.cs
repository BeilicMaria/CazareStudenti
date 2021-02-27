//Beilic Maria 3122B
using LibrarieModele;
using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;


namespace NivelAccesDate
{
    //clasa AdministrareStudenti_FisierText implementeaza interfata IStocareData
    public class AdministrareStudenti_FisierText : IStocareData
    {
        private const int ID_PRIMUL_STUDENT = 1;
        private const int INCREMENT = 1;
        private const int MINIM_CAZARE = 30;

        string NumeFisier { get; set; }
        public AdministrareStudenti_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
        }
        public void AddStudent(StudentCamin student)
        {
            student.IdStudent = GetId();
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {

                    swFisierText.WriteLine(student.ConversieLaSir_PentruFisier());
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

        public List<StudentCamin> GetStudenti()
        {
            List<StudentCamin> studenti = new List<StudentCamin>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita, repta pana ajunge la finalul documentului
                    while ((line = sr.ReadLine()) != null)
                    {
                        StudentCamin s = new StudentCamin(line);
                        studenti.Add(s);
                    }
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

            return studenti;
        }

        public StudentCamin GetStudent(string nume, string prenume)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        StudentCamin student = new StudentCamin(line);
                        if (student.Nume.Equals(nume) && student.Prenume.Equals(prenume))
                            return student;
                        
                           
                    }
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
            return null;
        }

        public bool UpdateStudent(StudentCamin studentActualizat)
        {
            List<StudentCamin> studenti = GetStudenti();
            
            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (StudentCamin stud in studenti)
                    {
                        //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                        if (stud.IdStudent != studentActualizat.IdStudent)
                        {
                            swFisierText.WriteLine(stud.ConversieLaSir_PentruFisier());
                        }
                        else
                        {
                            swFisierText.WriteLine(studentActualizat.ConversieLaSir_PentruFisier());
                            
                            
                        }
                    }
                    actualizareCuSucces = true;
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

            return actualizareCuSucces;
        }

        private int GetId()
        {
            int IdStudent = ID_PRIMUL_STUDENT;
            try
            {
                // instructiunea 'using' va apela sr.Close()
                //creează o instanta de tip streamreader care permite citirea din fisierul dat
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        StudentCamin s = new StudentCamin(line);
                        IdStudent = s.IdStudent + INCREMENT;
                    }
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
            return IdStudent;
        }
        public StudentCamin GetStudent(int index)
        {
           StudentCamin student = null;
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    int contor = 0;


                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null && contor < index)
                    {
                        student = new StudentCamin(line);


                        if (contor == index)
                            break;
                        contor++;


                    }
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
            return student;
        }

       

        public List<StudentCamin> GetStudentiCazati()
        {
            List<StudentCamin> studenti = GetStudenti();
            List<StudentCamin> studenti_cazati = new List<StudentCamin>();
            foreach (StudentCamin s in studenti)
            {
                if(s.Distanta>= MINIM_CAZARE)
                {
                    studenti_cazati.Add(s);
                }
            }
            return studenti_cazati;
        }

        public  bool DeleteStudent  (StudentCamin studentGresit)
        {
            List<StudentCamin> studenti = GetStudenti();
            int idid = 1;

            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (StudentCamin stud in studenti)
                    {
                       
                        if (stud.IdStudent != studentGresit.IdStudent )
                        {
                            stud.IdStudent = idid;
                            swFisierText.WriteLine(stud.ConversieLaSir_PentruFisier());
                            idid++;
                            
                        }
                       

                    }
                    actualizareCuSucces = true;
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

            return actualizareCuSucces;
        }


    }
}
