using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibUniversity
{
    [Serializable]
    public class University:Institute
    {
        public List<Professor>? Professors { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grades> Grades { get; set; }
        public List<Schedule> ScheduledCourse { get; set; }

        public University()
        {

        }

        public void GetProfessor(Professor professor)
        {
            Professors = new List<Professor>();
        }

        public void GetStudent()
        {
            Students = new List<Student>();
            
        }
        public void GetCourses()
        {
            Courses = new List<Course>();
        }
        public void GetGrades()
        {
            Grades = new List<Grades>();
        }
        public void SetSchedule(Guid courseID,Guid professorID, DateTime dateTime)
        {
            ScheduledCourse = new List<Schedule>();
        }
    }
}
