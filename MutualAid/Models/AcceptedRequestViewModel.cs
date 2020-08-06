using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.Models
{
    public class AcceptedRequestViewModel : BaseViewModel
    {
        public DateTime Date { get; set; }

        //foreign keys
        public int RequestId { get; set; }
        public RequestViewModel Request { get; set; }
        public int UserId { get; set; }
        public UserViewModel User { get; set; }
    }
}
