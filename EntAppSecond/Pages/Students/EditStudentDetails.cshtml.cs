using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntAppCA1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EntAppCA1.Pages.Students
{
    public class EditStudentDetailsModel : PageModel
    {
        private readonly StudentContext _db;

        public EditStudentDetailsModel(StudentContext db)
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
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Attach(Student).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception($"Student {Student.FirstName} {Student.LastName} not found!");
            }

            return RedirectToPage("/ListStudents");
        }
    }
}