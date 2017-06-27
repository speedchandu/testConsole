using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Username is required")]
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage ="Must be of minimum 8 characters")]
        [DisplayName("Password")]
        public string PasswordHash { get; set; }

        public bool RememberMe { get; set; }
    }
}