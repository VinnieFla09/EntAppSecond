using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntAppSecond.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages.Students
{
    public class CreateModel : PageModel
    {

        private readonly StudentContext _db;

        public CreateModel(StudentContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Student Student { get; set; } = new Student();


        //public void OnPost()
        //{
        //    if (Student.Email != Student.EmailConfirm)
        //    {
        //        ModelState.AddModelError("Student.Email", "emails don't match");
        //    }
        //    else
        //    {
        //        Student.StudentID = HttpContext.Session.GetString("StudentID");
        //        Student.FirstName = HttpContext.Session.GetString("FirstName");
        //        Student.LastName = HttpContext.Session.GetString("LastName");
        //    }
        //}

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(Student);
                await _db.SaveChangesAsync();
                return RedirectToPage("ListStudents");
            }

            else
            {
                return Page();
            }
        }




        //public void OnPost()
        //{
        //    if (Student.Email != Student.EmailConfirm)
        //    ModelState.AddModelError("Student.Email", "emails don't match");
        //}
    }
}