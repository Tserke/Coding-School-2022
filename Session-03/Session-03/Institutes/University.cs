using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class University : Institutes
    {
        public Student[] student { get; set; }
        public Institute.Course[] courses { get; set; }
        public Institute.Grade[] grades { set; get; }
        public Institute.Schedule[] ScheduledCourse { get; set; }

        public void GetStudents()
        { 
            student = new Student[30];
        }
        public void GetCourses()
        {
            courses = new Institute.Course[20];
        }
        public void GetGrades()
        {
            grades = new Institute.Grade[20];
        }
        public void SetScedule(Institute.Course CourseId, Professor ProfessorId, DateTime dateTime) {
            Institute.Schedule[] schedule = new Institute.Schedule[60];
        }
    }


}
