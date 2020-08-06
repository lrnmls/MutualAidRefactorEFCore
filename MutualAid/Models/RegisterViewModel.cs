using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.Models
{
    public class RegisterViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "Email address required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Confirm password required")]
        [Compare("Password", ErrorMessage = "Passwords do not match. Please try again.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Salt { get; set; }

        [Required(ErrorMessage = "First name required")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name required")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone number required")]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "County required")]
        [DisplayName("County")]
        public string County { get; set; }

        [Required]
        [DisplayName("Role")]
        public bool isAdmin { get; set; } 

        public DateTime Created { get; set; }

        [Required]
        public static List<SelectListItem> OhioCounties = new List<SelectListItem>()
        {
            new SelectListItem() {Text = "Adams", Value= "Adams"},
            new SelectListItem() {Text = "Allen", Value= "Allen"},
            new SelectListItem() {Text = "Ashland", Value= "Ashland"},
            new SelectListItem() {Text = "Ashtabula", Value= "Ashtabula"},
            new SelectListItem() {Text = "Athens", Value= "Athens"},
            new SelectListItem() {Text = "Auglaize", Value= "Auglaize"},
            new SelectListItem() {Text = "Belmont", Value= "Belmont"},
            new SelectListItem() {Text = "Brown", Value= "Brown"},
            new SelectListItem() {Text = "Butler", Value= "Butler"},
            new SelectListItem() {Text = "Carroll", Value= "Carroll"},
            new SelectListItem() {Text = "Champaign", Value= "Champaign"},
            new SelectListItem() {Text = "Clark", Value= "Clark"},
            new SelectListItem() {Text = "Clermont", Value= "Clermont"},
            new SelectListItem() {Text = "Clinton", Value= "Clinton"},
            new SelectListItem() {Text = "Columbiana", Value= "Columbiana"},
            new SelectListItem() {Text = "Coshocton", Value= "Coshocton"},
            new SelectListItem() {Text = "Crawford", Value= "Crawford"},
            new SelectListItem() {Text = "Cuyahoga", Value= "Cuyahoga"},
            new SelectListItem() {Text = "Darke", Value= "Darke"},
            new SelectListItem() {Text = "Defiance", Value= "Defiance"},
            new SelectListItem() {Text = "Delaware", Value= "Delaware"},
            new SelectListItem() {Text = "Erie", Value= "Erie"},
            new SelectListItem() {Text = "Fairfield", Value= "Fairfield"},
            new SelectListItem() {Text = "Fayette", Value= "Fayette"},
            new SelectListItem() {Text = "Franklin", Value= "Franklin"},
            new SelectListItem() {Text = "Fulton", Value= "Fulton"},
            new SelectListItem() {Text = "Gallia", Value= "Gallia"},
            new SelectListItem() {Text = "Geauga", Value= "Geauga"},
            new SelectListItem() {Text = "Greene", Value= "Greene"},
            new SelectListItem() {Text = "Guernsey", Value= "Guernsey"},
            new SelectListItem() {Text = "Hamilton", Value= "Hamilton"},
            new SelectListItem() {Text = "Hancock", Value= "Hancock"},
            new SelectListItem() {Text = "Hardin", Value= "Hardin"},
            new SelectListItem() {Text = "Harrison", Value= "Harrison"},
            new SelectListItem() {Text = "Henry", Value= "Henry"},
            new SelectListItem() {Text = "Highland", Value= "Highland"},
            new SelectListItem() {Text = "Holmes", Value= "Holmes"},
            new SelectListItem() {Text = "Huron", Value= "Huron"},
            new SelectListItem() {Text = "Jackson", Value= "Jackson"},
            new SelectListItem() {Text = "Jefferson", Value= "Jefferson"},
            new SelectListItem() {Text = "Knox", Value= "Knox"},
            new SelectListItem() {Text = "Lake", Value= "Lake"},
            new SelectListItem() {Text = "Lawrence", Value= "Lawrence"},
            new SelectListItem() {Text = "Licking", Value= "Licking"},
            new SelectListItem() {Text = "Logan", Value= "Logan"},
            new SelectListItem() {Text = "Lorain", Value= "Lorain"},
            new SelectListItem() {Text = "Lucas", Value= "Lucas"},
            new SelectListItem() {Text = "Madison", Value= "Madison"},
            new SelectListItem() {Text = "Mahoning", Value= "Mahoning"},
            new SelectListItem() {Text = "Marion", Value= "Marion"},
            new SelectListItem() {Text = "Medina", Value= "Medina"},
            new SelectListItem() {Text = "Meigs", Value= "Meigs"},
            new SelectListItem() {Text = "Mercer", Value= "Mercer"},
            new SelectListItem() {Text = "Miami", Value= "Miami"},
            new SelectListItem() {Text = "Monroe", Value= "Monroe"},
            new SelectListItem() {Text = "Montgomery", Value= "Montgomery"},
            new SelectListItem() {Text = "Morgan", Value= "Morgan"},
            new SelectListItem() {Text = "Morrow", Value= "Morrow"},
            new SelectListItem() {Text = "Muskingum", Value= "Muskingum"},
            new SelectListItem() {Text = "Noble", Value= "Noble"},
            new SelectListItem() {Text = "Ottawa", Value= "Ottawa"},
            new SelectListItem() {Text = "Paulding", Value= "Paulding"},
            new SelectListItem() {Text = "Perry", Value= "Perry"},
            new SelectListItem() {Text = "Pickaway", Value= "Pickaway"},
            new SelectListItem() {Text = "Pike", Value= "Pike"},
            new SelectListItem() {Text = "Portage", Value= "Portage"},
            new SelectListItem() {Text = "Preble", Value= "Preble"},
            new SelectListItem() {Text = "Putnam", Value= "Putnam"},
            new SelectListItem() {Text = "Richland", Value= "Richland"},
            new SelectListItem() {Text = "Ross", Value= "Ross"},
            new SelectListItem() {Text = "Sandusky", Value= "Sandusky"},
            new SelectListItem() {Text = "Scioto", Value= "Scioto"},
            new SelectListItem() {Text = "Seneca", Value= "Seneca"},
            new SelectListItem() {Text = "Shelby", Value= "Shelby"},
            new SelectListItem() {Text = "Stark", Value= "Stark"},
            new SelectListItem() {Text = "Summit", Value= "Summit"},
            new SelectListItem() {Text = "Trumbull", Value= "Trumbll"},
            new SelectListItem() {Text = "Tuscarawas", Value= "Tuscarawas"},
            new SelectListItem() {Text = "Union", Value= "Union"},
            new SelectListItem() {Text = "Van Wert", Value= "Van Wert"},
            new SelectListItem() {Text = "Vinton", Value= "Vinton"},
            new SelectListItem() {Text = "Warren", Value= "Warren"},
            new SelectListItem() {Text = "Washington", Value= "Washington"},
            new SelectListItem() {Text = "Wayne", Value= "Wayne"},
            new SelectListItem() {Text = "Williams", Value= "Williams"},
            new SelectListItem() {Text = "Wood", Value= "Wood"},
            new SelectListItem() {Text = "Wyandot", Value= "Wyandot" }
        };
    }
}
