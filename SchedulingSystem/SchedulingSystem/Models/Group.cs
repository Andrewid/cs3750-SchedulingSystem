using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class Group
    {
        public int GroupID { get; set; }
        public string Name { get; set; }

        public ICollection<UserGroup> UserGroups { get; set; }
    }
}
