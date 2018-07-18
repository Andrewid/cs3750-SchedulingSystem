using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class InstructorPreferenceCourse
    {
        public int InstructorPreferenceCourseID { get; set; }
        public int EmployeeID { get; set; }
        public int CourseID { get; set; }


        public Employee Employee { get; set; }
        public Course Course { get; set; }
    }
}
