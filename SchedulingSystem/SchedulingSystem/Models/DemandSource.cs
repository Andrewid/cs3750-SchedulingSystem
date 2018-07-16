using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class DemandSource
    {
        public int DemandSourceID { get; set; }
        public string DemandSourceName { get; set; }
        public DateTime DemandSourceDate { get; set; }

        public Demand Demand { get; set; }
    }
}
