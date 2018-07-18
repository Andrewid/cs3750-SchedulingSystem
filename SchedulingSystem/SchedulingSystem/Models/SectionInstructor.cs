using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class SectionInstructor
    {
        public int SectionInstructorID { get; set; }
        public int SectionID    { get; set; }
        public int InstructorID { get; set; }

        public Section  Section  { get; set; }
        public Employee Employee { get; set; } 
    }
}
