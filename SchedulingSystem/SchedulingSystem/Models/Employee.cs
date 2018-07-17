using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace SchedulingSystem.Models
{
    public class Employee
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]  ---> Pause
        public int EmployeeID { get; set; }

        public string EmployeeFristName { get; set; }

        public string EmployeeLastName { get; set; }

        public string EmployeeEmail { get; set; }

        public string EmployeePhoneNumber { get; set; }

        public string EmployeeTitle { get; set; }

        public float EmployeeReqHours { get; set; }

        

        public ICollection<EmployeeGroup> EmployeeGroups { get; set; }
        public ICollection<InstructorPreference> InstructorPreferences { get; set; }
        public ICollection<InstructorPreferenceCourse> InstructorPreferenceCourses { get; set; }
        public Authentcation Authentcation { get; set; }
    }
}
