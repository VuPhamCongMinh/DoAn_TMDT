using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTMDT.ViewModels
{
    public class LoginRegisterViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password",
           ErrorMessage = "Password and confirmation password do not match.")]
        public string PasswordConfirm { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
