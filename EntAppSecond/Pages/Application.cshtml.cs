using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntAppCA1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppCA1.Pages
{
    public class ApplicationModel : PageModel
    {

        public string[] DaysOfWeek { get; set; } = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
        [BindProperty]
        public bool[] DaysSelected { get; set; }
        = { false, false, false, false, false, false, false };


        


    private readonly StudentContext _db;

        public ApplicationModel(StudentContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Student Student { get; set; } = new Student();

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                //GetGender();
                //GetHours();
                //GetDays();

                _db.Students.Add(Student);
                await _db.SaveChangesAsync();
                return RedirectToPage("ListStudents");
            }

            else
            {
                return Page();
            }
        }

        //private void GetGender()
        //{
        //    if (Student.Female == true)
        //    {
        //        Student.Gender = "Female";
        //    }
        //    else if (Student.Male == true)
        //    {
        //        Student.Gender = "Male";
        //    }
        //    else
        //        Student.Gender = "Unknown";
        //}

        //private void GetHours()
        //{
        //    if (Student.FullHours == true)
        //    {
        //        Student.Hours = "Full-Time";
        //    }
        //    else if (Student.PartHours == true)
        //    {
        //        Student.Hours = "Part-Time";
        //    }
        //    else
        //        Student.Hours = "Unkown";
        //}

        //private void GetDays()
        //{

        //    for (int i = 0; i < DaysSelected.Length; i++)
        //    {
        //        if (DaysSelected[i] == true)
        //        {
        //            Student.Days += string.Format("{0} ", DaysOfWeek[i]);
        //        }
        //    }
        //}

    }
}