using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class Semester
    {
        public int SemesterID { get; set; }
        public int SemesterYear { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        public int StatusID { get; set; }
        public int SemesterNameID { get; set; }

        public ICollection<Section> Sections { get; set; }
        public ICollection<Demand> Demands { get; set; }
        public Status Status { get; set; }
        public SemesterName SemesterName { get; set; }
    }
}
