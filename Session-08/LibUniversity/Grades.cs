using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibUniversity
{
    [Serializable]
    public class Grades
    { 
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int Grade { get; set; }

        public Grades() { }
    }
}
