using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.Models
{
    public class LoginViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "Please enter your email address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please enter your password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
