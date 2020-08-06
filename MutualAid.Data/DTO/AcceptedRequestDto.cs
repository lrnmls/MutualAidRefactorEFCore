using MutualAidRefactorEFCore.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAid.Data.DTO
{
    public class AcceptedRequestDto
    {
        public DateTime Date { get; set; }

        //foreign keys
        public int RequestId { get; set; }
        public RequestDto Request { get; set; }
        public int UserId { get; set; }
        public UserDto User { get; set; }
    }
}
