using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class Semester
    {
        public int SemesterID { get; set; }
        public int SemesterYear { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StatusID { get; set; }
        public int SemesterNameID { get; set; }

        public ICollection<Section> Section { get; set; }
        public Status Status { get; set; }
        public SemesterName SemesterName { get; set; }
    }
}
