using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.Models
{
    public class BaseViewModel
    {
        [DisplayName("Confirmation #")]
        public int Id { get; set; }
    }
}
