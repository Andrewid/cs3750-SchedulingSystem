using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchedulingSystem.Models;

namespace SchedulingSystem.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly SchedulingSystem.Models.SchedulingSystemContext _context;

        public DeleteModel(SchedulingSystem.Models.SchedulingSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Section Section { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Section = await _context.Section
                .Include(s => s.Course)
                .Include(s => s.DayBlock)
                .Include(s => s.Room)
                .Include(s => s.Semester)
                .Include(s => s.Status)
                .Include(s => s.TimeBlock).FirstOrDefaultAsync(m => m.SectionID == id);

            if (Section == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Section = await _context.Section.FindAsync(id);

            if (Section != null)
            {
                _context.Section.Remove(Section);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
