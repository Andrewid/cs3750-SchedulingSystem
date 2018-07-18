﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchedulingSystem.Models;

namespace SchedulingSystem.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SchedulingSystem.Models.SchedulingSystemContext _context;

        public IndexModel(SchedulingSystem.Models.SchedulingSystemContext context)
        {
            _context = context;
        }

        public IList<Section> Section { get;set; }

        public async Task OnGetAsync()
        {
            Section = await _context.Section
                .Include(s => s.Course)
                .Include(s => s.DayBlock)
                .Include(s => s.Room)
                .Include(s => s.Semester)
                .Include(s => s.Status)
                .Include(s => s.TimeBlock).ToListAsync();
        }
    }
}
