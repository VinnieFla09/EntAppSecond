using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntAppCA1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppCA1.Pages.Students
{
    public class StudentDetailsModel : PageModel
    {
        private readonly StudentContext _db;

        public StudentDetailsModel(StudentContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            Student = await _db.Students.FindAsync(id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            var student = await _db.Students.FindAsync(Student.PpsNumber);

            if (student != null)
            {
                _db.Students.Remove(student);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage("ListStudents");
        }
    }
}