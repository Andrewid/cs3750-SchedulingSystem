using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class SemesterName
    {
        public int SemesterNameID { get; set; }
        public string SemesterNameShort { get; set; }
        public string SemesterNameDescription { get; set; }

        public ICollection<Semester> Semester { get; set; }
    }
}
