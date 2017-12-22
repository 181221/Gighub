using System.ComponentModel.DataAnnotations;

namespace gighub.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}