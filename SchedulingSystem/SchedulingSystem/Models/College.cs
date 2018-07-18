using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class College
    {
        public int    CollegeID   { get; set; }
        [Display(Name = "College Name")]
        [StringLength(50)]
        public string CollegeName { get; set; }

        public ICollection<Department> Departments { get; set; }
    }
}
