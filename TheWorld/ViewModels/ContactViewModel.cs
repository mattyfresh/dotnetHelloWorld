using System.ComponentModel.DataAnnotations;

namespace TheWorld.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(5000, MinimumLength = 20)]
        public string Message { get; set; }
        
    }
}
