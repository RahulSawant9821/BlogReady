using System.ComponentModel.DataAnnotations;

namespace BlogReady.ViewModel
{
    public class RegisterViewModel
    {
    
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = " Confirm Password")]
        [Compare("Password",
            ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
