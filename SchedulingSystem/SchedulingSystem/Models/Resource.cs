using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class Resource
    {
        public int ResourceID { get; set; }
        public string Description { get; set; }
        public string ResourceName { get; set; }

        public ICollection<RoomResource> RoomResources { get; set; }
    }
}
