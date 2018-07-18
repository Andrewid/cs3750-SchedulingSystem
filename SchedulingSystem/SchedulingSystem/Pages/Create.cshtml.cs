using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchedulingSystem.Models;

namespace SchedulingSystem.Pages
{
    public class CreateModel : PageModel
    {
        private readonly SchedulingSystem.Models.SchedulingSystemContext _context;

        public CreateModel(SchedulingSystem.Models.SchedulingSystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CourseID"] = new SelectList(_context.Set<Course>(), "CourseID", "CourseID");
        ViewData["DayBlockID"] = new SelectList(_context.Set<DayBlock>(), "DayBlockID", "DayBlockID");
        ViewData["RoomID"] = new SelectList(_context.Set<Room>(), "RoomID", "RoomID");
        ViewData["SemesterID"] = new SelectList(_context.Set<Semester>(), "SemesterID", "SemesterID");
        ViewData["StatusID"] = new SelectList(_context.Set<Status>(), "StatusID", "StatusID");
        ViewData["TimeBlockID"] = new SelectList(_context.Set<TimeBlock>(), "TimeBlockID", "TimeBlockID");
            return Page();
        }

        [BindProperty]
        public Section Section { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Section.Add(Section);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}