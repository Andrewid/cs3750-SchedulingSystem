using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public int DepartmentID { get; set; }
        public string CourseName { get; set; }
        public int CourseCredits { get; set; }
        public string CourseCode { get; set; }
        
        public ICollection<Section> Sections { get; set; }
        public ICollection<InstructorPreferenceCourse> 
            InstructorPreferenceCourses { get; set; }
        public Demand Demand { get; set; }
        public Department Department { get; set; }
    }
}
