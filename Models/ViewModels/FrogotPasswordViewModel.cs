using System.ComponentModel.DataAnnotations;

namespace IdentityManagers.Models.ViewModels
{
    public class FrogotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
