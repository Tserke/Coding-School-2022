using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Professor : Person
    {
        public string Rank { get; set; }
        public Institute.Course[] courses { get; set; }

        public void Teach(Institute.Course courses, DateTime dateTime) { }
        public void SetGrade(Student studentID, Institute.Course courseID) { }


    }

    


}
