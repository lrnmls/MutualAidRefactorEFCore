using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.Models
{
    public class RequestViewModel : BaseViewModel
    {
        public int UserId { get; set; }
        public UserViewModel User { get; set; }
        [DisplayName("Accepted")]
        public bool IsAccepted { get; set; }
        public DateTime Date { get; set; }

        //toiletries 
        [DisplayName("Toilet Paper")]
        public string ToiletPaper { get; set; }
        [DisplayName("Paper Towels")]
        public string PaperTowels { get; set; }
        [DisplayName("Hand Soap")]
        public string HandSoap { get; set; }
        public string Shampoo { get; set; }
        public string Conditioner { get; set; }
        public string Toothpaste { get; set; }
        public string Disinfectant { get; set; }

        //food
        public string Dairy { get; set; }
        public string Bread { get; set; }
        public string Produce { get; set; }
        [DisplayName("Canned Goods")]
        public string CannedFood { get; set; }
        public string Meat { get; set; }
        public string Seafood { get; set; }
        public string Cereal { get; set; }
        public string Pantry { get; set; }

        //allergies
        public string Allergens { get; set; }

        private string toYesNo(bool b)
        {
            return b ? "Yes" : "No";
        }
        
        public string IsAcceptedString
        {
            get { return this.toYesNo(this.IsAccepted); }
        }
    }
}
