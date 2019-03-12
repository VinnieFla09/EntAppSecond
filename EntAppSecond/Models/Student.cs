using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppCA1.Models
{
    public class Student
    {
        [Required]
        [Display(Name = "Child's PPS number")]
        [Key]
        public string PpsNumber { get; set; } = "";

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
        [Display(Name = "Child's date of birth")]
        public string Dob { get; set; }

        [Required(ErrorMessage = "Please select a gender.")]
        [Display(Name = "Child's Gender")]
        public string Gender { get; set; } = "";


        //[Display(Name = "Female Child")]
        //public bool Female { get; set; } = false;

        
        //[Display(Name = "Male Child")]
        //public bool Male { get; set; } = false;

        [Required(ErrorMessage = "Parent/Guardian First Name must have at least 2 characters")]
        [RegularExpression(@"\w{2,50}")]
        [Display(Name = "Parent/Guardian First Name")]
        public string ParentFirstName { get; set; } = "";

        [Required(ErrorMessage = "Guardian Last Name must have at least 3 characters")]
        [RegularExpression(@"\w{3,50}")]
        [Display(Name = "Parent/Guardian Last Name")]
        public string ParentLastName { get; set; } = "";

        [Required]
        [Display(Name = "Relationship to child")]
        public string Relationship { get; set; } = "";

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; } = "";

        //[Required]
        //[DataType(DataType.PhoneNumber)]
        //[Display(Name = "Phone Number")]
        //public string PhoneNumber { get; set; } = "";

        //[Required]
        //[DataType(DataType.PhoneNumber)]
        //[Display(Name = "Alternative Phone Number")]
        //public string AltPhoneNumber { get; set; } = "";

        //[Required]
        //[DataType(DataType.EmailAddress)]
        //[Display(Name = "Email Address")]
        //public string Email { get; set; } = "";

        //[Required]
        //[DataType(DataType.EmailAddress)]
        //[Display(Name = "Alternate Email Address")]
        //public string AltEmail { get; set; } = "";

        [Required]
        [Display(Name = "Hours Requested")]
        public string Hours { get; set; } = "";

        //[Display(Name = "Full-time Hours")]
        //public bool FullHours { get; set; } = false;


        //[Display(Name = "Part Time Hours")]
        //public bool PartHours { get; set; } = false;

        //[Required]
        //[Display(Name = "Days Requested")]
        //public string Days { get; set; }

        //[Required(ErrorMessage = "Date entered must be in the future")]
        //[DataType(DataType.Date)]
        //[Display(Name = "Requested start date")]
        //public string StartDate { get; set; }



        //[Required(ErrorMessage = "Student ID must start with S and folowed by 7 digits")]
        //[RegularExpression(@"(s|S)\d{7}")]
        //[Display(Name = "Student ID")]
        //public string StudentID { get; set; } = "";

        //[Required(ErrorMessage = "First Name must have at least 2 characters")]
        //[RegularExpression(@"\w{2,50}")]
        //[Display(Name = "First Name")]
        //public string FirstName { get; set; } = "";

        //[Required(ErrorMessage = "Last Name must have at least 3 characters")]
        //[RegularExpression(@"\w{3,50}")]
        //[Display(Name = "Last Name")]
        //public string LastName { get; set; } = "";

        //[Required(ErrorMessage = "Date entered incorrect")]
        //[DataType(DataType.Date)]
        //[Display(Name = "Date of Birth")]
        //public DateTime Dob { get; set; }

        //[Required(ErrorMessage = "Number of modules must be between 1 and 10")]
        //[Range(2, 10)]
        //[Display(Name = "Number of Module")]
        //public byte NumberOfModule { get; set; }

        //[Required(ErrorMessage = "Height must be between 50 and 250cm")]
        //[Range(50, 250)]
        //[Display(Name = "Hight in cm")]
        //public byte Height { get; set; }

        //[EmailAddress]
        //[Required]
        //[RegularExpression(@"[\w-]+@([\w-]+\.)+[\w-]+")]
        //public string Email { get; set; }

        //[EmailAddress]
        //[Required]
        //[RegularExpression(@"[\w-]+@([\w-]+\.)+[\w-]+")]
        //public string EmailConfirm { get; set; }






    }
}
