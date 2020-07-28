using MutualAid.Data.DTO;
using MutualAid.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAidRefactorEFCore.Data.DTO
{
    [Serializable]
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string County { get; set; }
        public bool isAdmin { get; set; } 
        public DateTime Created { get; set; }

        public IEnumerable<RequestDto> Requests { get; set; }
    }
}
