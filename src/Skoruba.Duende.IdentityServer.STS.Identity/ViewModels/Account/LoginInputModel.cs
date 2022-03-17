// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.

// Original file: https://github.com/DuendeSoftware/IdentityServer.Quickstart.UI
// Modified by Jan Škoruba

using System.ComponentModel.DataAnnotations;

namespace Skoruba.Duende.IdentityServer.STS.Identity.ViewModels.Account
{
    public class LoginInputModel
    {
        [Required]
        [MinLength(4)]
        [MaxLength(16)]
        public string Username { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }
    }
}