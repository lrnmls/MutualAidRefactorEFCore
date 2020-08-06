using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.Models
{
    public class UserPasswordViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "Current password is required.")]
        [DataType(DataType.Password)]
        [DisplayName("Current Password")]
        public string ExistingPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("New Password")]
        public string NewPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "Passwords do not match. Please try again.")]
        [DisplayName("Confirm New Password")]
        public string ConfirmNewPassword { get; set; }
    }
}
