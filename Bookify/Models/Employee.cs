using System.ComponentModel.DataAnnotations;

namespace Bookify.Models
{
    public class Employee
    {
        [Key]
        [Required(ErrorMessage = "ID is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[a-zA-Z\s]{15,}$", ErrorMessage = "Name contain only alphabets and spaces and be at least 15 characters long")]
        public string Name { get; set; }

        [Required]
        public string Username { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "2002-01-01", "2005-12-31", ErrorMessage = "Year of Birth should be between 2002 and 2005")]
        public DateTime DateOfBirth { get; set; }


        [Required(ErrorMessage = "Date of Joining is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Joining")]
        public DateTime DateOfJoining { get; set; }


        [Range(12000, 60000, ErrorMessage = "Salary  between 12000 and 60000")]
        public decimal? Salary { get; set; }
       

        [Required(ErrorMessage = "Department is required")]
        [RegularExpression(@"^(HR|Accts|IT)$", ErrorMessage = "Department must be HR, Accts, or IT")]
        public string Dept { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Retype Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string RetypePassword { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Address { get; set; }

    }
}
   
