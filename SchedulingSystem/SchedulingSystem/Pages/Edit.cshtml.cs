using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchedulingSystem.Models;

namespace SchedulingSystem.Pages
{
    public class EditModel : PageModel
    {
        private readonly SchedulingSystem.Models.SchedulingSystemContext _context;

        public EditModel(SchedulingSystem.Models.SchedulingSystemContext context)
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
           ViewData["CourseID"] = new SelectList(_context.Set<Course>(), "CourseID", "CourseID");
           ViewData["DayBlockID"] = new SelectList(_context.Set<DayBlock>(), "DayBlockID", "DayBlockID");
           ViewData["RoomID"] = new SelectList(_context.Set<Room>(), "RoomID", "RoomID");
           ViewData["SemesterID"] = new SelectList(_context.Set<Semester>(), "SemesterID", "SemesterID");
           ViewData["StatusID"] = new SelectList(_context.Set<Status>(), "StatusID", "StatusID");
           ViewData["TimeBlockID"] = new SelectList(_context.Set<TimeBlock>(), "TimeBlockID", "TimeBlockID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Section).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SectionExists(Section.SectionID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SectionExists(int id)
        {
            return _context.Section.Any(e => e.SectionID == id);
        }
    }
}
