using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class Section
    {
        public int SectionID { get; set; }
        public int RoomID { get; set; }
        public string SectionInstructrorID { get; set; }
        public int CourseID { get; set; }
        public int TimeBlockID { get; set; }
        public int DayBlockID { get; set; }
        public int StatusID { get; set; }
        public int SemesterID { get; set; }

        public Course Course { get; set; }
    }
}
