using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class SemesterName
    {
        public int    SemesterNameID { get; set; }
        [Display(Name="Abbreviated Semester Name")]
        [StringLength(10)]
        public string SemesterNameShort { get; set; }
        [Display(Name = "Semester Name Description")]
        [StringLength(35)]
        public string SemesterNameDescription { get; set; }

        public ICollection<Semester> Semester { get; set; }
    }
}
