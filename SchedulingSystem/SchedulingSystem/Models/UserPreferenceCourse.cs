using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class UserPreferenceCourse
    {
        public int UserPreferenceCourseID { get; set; }
        public int UserID { get; set; }
        public int CourseID { get; set; }

        public Course Course { get; set; }
    }
}
