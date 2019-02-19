using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppSecond.Models
{
    public class Student
    {
        [Required (ErrorMessage = "Please enter a student ID!")]
        public string StudentID { get; set; } = "";

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = "";
       

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = "";
    }
}
