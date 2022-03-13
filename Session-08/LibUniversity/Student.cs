using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibUniversity
{
    [Serializable]
    public class Student:Person
    {
        public int RegistrationNumber { get; set; }
        public List<Course>  Courses{ get; set; }
        public Student()
        {
            Name = String.Empty;
            Age = 0;
        }
        public Student ShallowCopy()
        {
            return (Student)MemberwiseClone();
        }
        public void Attend(Course course, DateTime dateTime)
        {

        }

        public void WriteExam(Course course, DateTime dateTime)
        {

        }
    }
    public class Manager
    {

    }

    public class StudentManager : Manager
    {

        public List<Student> Students { get; set; }

        public StudentManager()
        {
            Students = new List<Student>();
        }


        public Student AddStudent()
        {

            return AddStudent("{enter name}", 0);
        }

        public Student AddStudent(string name)
        {

            return AddStudent(name, 0);
        }

        public Student AddStudent(string name, int age)
        {

            Student student = new Student()
            {
                Name = name,
                Age = age,
            };

            Students.Add(student);

            return student;
        }

    }

    [Serializable]
    public class PetShop
    {

        public List<Student>? Pets { get; set; }

        public PetShop()
        {

        }



    }
}
