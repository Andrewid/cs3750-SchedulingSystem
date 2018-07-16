using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class Status
    {
        public int StatusID { get; set; }
        public String StatusName { get; set; }

        public ICollection<Section> Section { get; set; }
        public ICollection<Semester> Semester { get; set; }
    }
}