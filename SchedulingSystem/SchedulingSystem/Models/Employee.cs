using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace SchedulingSystem.Models
{
    public class Employee
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]  ---> Pause
        public int EmployeeID { get; set; }

        [Display(Name = "First Name")]
        [StringLength(35)]
        public string EmployeeFirstName { get; set; }
        [Display(Name = "Last Name")]
        [StringLength(35)]
        public string EmployeeLastName { get; set; }
        [Display(Name = "Email")]
        [StringLength(35)]
        public string EmployeeEmail { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        //[StringLength(35)]
        public string EmployeePhoneNumber { get; set; }

        public string EmployeeTitle { get; set; }

        public float EmployeeReqHours { get; set; }

        

        public ICollection<EmployeeGroup> EmployeeGroups { get; set; }
        public ICollection<InstructorPreference> InstructorPreferences { get; set; }
        public ICollection<InstructorPreferenceCourse> InstructorPreferenceCourses { get; set; }      
    }
}
