using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Student : Person
    {
        public int RegistrationNumber { get; set; }

        public Institute.Course[] courses { get; set; }

        public void Attend(Institute.Course course, DateTime dateTime) { }
        public void WhiteExam(Institute.Course course, DateTime dateTime) { }

    }
}
