using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace SchedulingSystem.Models
{
    public class Authentcation
    {
        public int EmployeeAuthID { get; set; }

        public string Salt { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string PasswordChallenge { get; set; }

        [StringLength(10)]
        public string PasswordChallengeAnswer { get; set; }
        
        public string Token { get; set; }

        public string Session { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TokenDateTime { get; set; }

        public int UserID { get; set; }

        public string Username { get; set; }

        public Employee Employee { get; set; }

    }
}
