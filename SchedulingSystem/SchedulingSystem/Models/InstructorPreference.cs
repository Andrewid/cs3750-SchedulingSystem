using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class InstructorPreference
    {
        public int InstructorPreferenceID { get; set; }

        public int LocationID { get; set; }

        public int TimeBlockID { get; set; }

        public int EmployeeID { get; set; }

        public int DayBlockID { get; set; }

       public bool Available { get; set; }



        public Employee Employee { get; set; }
        public TimeBlock TimeBlock { get; set; }
        public DayBlock DayBlock { get; set; }
        public Location Location { get; set; }

    }
}
