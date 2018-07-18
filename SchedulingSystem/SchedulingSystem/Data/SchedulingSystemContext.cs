using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchedulingSystem.Models
{
    public class SchedulingSystemContext : DbContext
    {
        public SchedulingSystemContext (DbContextOptions<SchedulingSystemContext> options)
            : base(options)
        {
        }

        public DbSet<SchedulingSystem.Models.Section> Section { get; set; }
    }
}
