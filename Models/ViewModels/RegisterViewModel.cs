using System.ComponentModel.DataAnnotations;

namespace IdentityManagers.Models.ViewModels
{
    public class RegisterViewModel
    {
        //Name
        [Required]
        public string Name { get; set; }
        //Email
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        //Password
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //Confirm Password
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password",ErrorMessage ="The Password and The Confirmation Password Don't Match")]
        public string ConfirmPassword { get; set; }
    }
}
