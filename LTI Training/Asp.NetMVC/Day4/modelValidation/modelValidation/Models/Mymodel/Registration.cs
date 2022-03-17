using System.ComponentModel.DataAnnotations;

namespace modelValidation.Models.Mymodel
{
    public class Registration
    {
        [Key]
        public string Id { get; set; }
        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "UserName")]

        public string Uname { get; set; }

        [Required(ErrorMessage = "DateOfBirth is required")]
        [Display(Name = "DateOfBirth")]

        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]

        public string Password { get; set; }


        [Required(ErrorMessage = "Please Enter ConfirmPassword")]
        [Compare("Password", ErrorMessage = "Password and ConfirmPassword Should be same")]
        
         public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Please Enter Email")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
