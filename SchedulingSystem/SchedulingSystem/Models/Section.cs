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
        public int CourseID { get; set; }
        public int TimeBlockID { get; set; }
        public int DayBlockID { get; set; }
        public int StatusID { get; set; }
        public int SemesterID { get; set; }


         public Room Room { get; set; }  
         public TimeBlock TimeBlock { get; set;}
        public DayBlock DayBlock  { get; set;}
       public Semester Semester { get; set; }

        public Course Course { get; set; }
        public Status Status { get; set; }// add

        public ICollection<SectionInstructor> SectionInstructor { get; set; } 


    }
}
