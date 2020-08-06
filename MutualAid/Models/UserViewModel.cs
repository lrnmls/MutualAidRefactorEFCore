using Microsoft.AspNetCore.Mvc.Rendering;
using MutualAid.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.Models
{
    public class UserViewModel : BaseViewModel
    {
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Salt { get; set; }

        [Required]
        [EmailAddress]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DisplayName("County")]
        public string County { get; set; }

        [DisplayName("Role")]
        public bool isAdmin { get; set; }

        public DateTime Created { get; set; }

        public IEnumerable<RequestViewModel> Requests { get; set; }

        public string IsAdminOrUserString
        {
            get { return this.toUserOrAdmin(this.isAdmin); }
        }
        private string toUserOrAdmin(bool b)
        {
            return b ? "Admin" : "User";
        }

        public string TimeOfDay
        {
            get { return this.GetTimeOfDay(); }
        }
        private string GetTimeOfDay()
        {
            int hour = DateTime.Now.Hour;

            if (hour >= 0 && hour < 12)
            {
                return "Good Morning";
            }
            else if (hour >= 12 && hour < 17)
            {
                return "Good afternoon";
            }
            return "Good evening";
        }
    }
}
