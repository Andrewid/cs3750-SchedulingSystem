using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class Authentcation
    {
        public int EmployeeAuthID { get; set; }

        public string Salt { get; set; }

        public string Password { get; set; }

        public string PasswordChalange { get; set; }

        public string PasswordChalangeAnswer { get; set; }
        
        public string Token { get; set; }

        public string Sesstion { get; set; }

        public DateTime TokenDateTime { get; set; }

        public int UserID { get; set; }

        public string Username { get; set; }



        public Employee Employee { get; set; }

    }
}
