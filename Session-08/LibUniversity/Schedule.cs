using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibUniversity
{
    [Serializable]
    public class Schedule
    {
        public Guid Id { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Callendar { get; set; }
    }
}
