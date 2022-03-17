using System.ComponentModel.DataAnnotations;

namespace Skoruba.Duende.IdentityServer.STS.Identity.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [MinLength(4)]
        [MaxLength(16)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [MinLength(6)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}