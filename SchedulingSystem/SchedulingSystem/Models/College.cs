using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class College
    {
        public int CollegeID { get; set; }
        public string CollegeName { get; set; }

        public ICollection<Department> Departments { get; set; }
    }
}
