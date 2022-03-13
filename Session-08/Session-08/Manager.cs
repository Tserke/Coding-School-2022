using LibUniversity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_08
{
    public class Manager
    {
    }

    public class ProfessorManager : Manager
    {
        public List<Professor> Professors { get; set; }

        public ProfessorManager()
        {
            Professors = new List<Professor>();
        }

        public Professor AddProfessor ()
        {
            return AddProfessor("(enter name)", 0);
        }

        public Professor AddProfessor(string name)
        {
         return AddProfessor(name,0);
        }
        public Professor AddProfessor (string name, int  age)
        {
            Professor professor = new Professor()
            {
                Name = name,
                Age = age,
            };
            Professors.Add(professor);
            return professor;
        }
    }
}
