using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppSecond.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Student ID must start with S and folowed by 7 digits")]
        [RegularExpression(@"(s|S)\d{7}")]
        [Display(Name = "Student ID")]
        public string StudentID { get; set; } = "";

        [Required(ErrorMessage = "First Name must have at least 2 characters")]
        [RegularExpression(@"\w{2,50}")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = "";

        [Required(ErrorMessage = "Last Name must have at least 3 characters")]
        [RegularExpression(@"\w{3,50}")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = "";

        [Required(ErrorMessage = "Date entered incorrect")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Number of modules must be between 1 and 10")]
        [Range(2, 10)]
        [Display(Name = "Number of Module")]
        public byte NumberOfModule { get; set; }

        [Required(ErrorMessage = "Height must be between 50 and 250cm")]
        [Range(50, 250)]
        [Display(Name = "Hight in cm")]
        public byte Height { get; set; }

        [EmailAddress]
        [Required]
        [RegularExpression(@"[\w-]+@([\w-]+\.)+[\w-]+")]
        public string Email { get; set; }

        [EmailAddress]
        [Required]
        [RegularExpression(@"[\w-]+@([\w-]+\.)+[\w-]+")]
        public string EmailConfirm { get; set; }
    }
}
