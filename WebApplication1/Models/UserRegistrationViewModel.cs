using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserRegistrationViewModel
    {
        [Required(ErrorMessage ="Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage ="Must be atleast 8 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password Doesnot match.")]
        public string ConfirmPassword { get; set; }
    }
}