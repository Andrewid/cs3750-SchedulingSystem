using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class EmployeeGroup
    {
        public int EmployeeGroupID { get; set; }
        public int EmployeeID { get; set; }
        public int GroupID { get; set; }

        public Employee Employee { get; set; }
        public Group Group { get; set; }
    }
}
