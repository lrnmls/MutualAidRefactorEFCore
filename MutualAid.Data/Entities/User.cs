using MutualAid.Data.Context;
using MutualAid.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAid.Data.Entities
{
    public class User : BaseEntity
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string County { get; set; }
        public bool isAdmin { get; set; }
        public DateTime Created { get; set; }

        public IEnumerable<Request> Requests { get; set; }
    }
}
