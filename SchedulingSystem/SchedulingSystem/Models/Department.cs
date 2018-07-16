using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentPhone { get; set; }
        public int CollegeID { get; set; }
        public string DepartmentPrefix { get; set; }

        public ICollection<Course> Courses { get; set; }
        public College College { get; set; }
    }
}
