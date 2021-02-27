//Beilic Maria 3122B
using LibrarieModele;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddStudent(StudentCamin s);
        List <StudentCamin> GetStudenti();
        
        List<StudentCamin> GetStudentiCazati();

        StudentCamin GetStudent(string nume, string prenume);
        StudentCamin GetStudent(int index);
        

        bool UpdateStudent(StudentCamin s);
        bool DeleteStudent(StudentCamin s);
    }
}
