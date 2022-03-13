using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibUniversity
{
    [Serializable]
    public class Professor: Person
    {
        public string Rank { get; set; }
        public List<Course> Courses { get; set; }
        public Professor() { }

        public void Teach (string course, DateTime datetime)
        {
            Name = string.Empty;
            Age = 0;
            Rank = string.Empty;

        }
        
        public int SetGrade(Guid studentID,Guid courseID, int grade)
        {
            return 0;
        }
        
        public Professor ShallowCopy()
        {
            return(Professor)MemberwiseClone();
        }

        
    }
}
