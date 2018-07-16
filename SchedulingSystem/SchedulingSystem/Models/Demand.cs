using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class Demand
    {
        public int DemandID { get; set; }
        public int CourseID { get; set; }
        public int SemesterID { get; set; }
        public int DemandStudents { get; set; }
        public int DemandSourceID { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
