using MutualAid.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAid.Application.UnitTest
{
    public static class MockDataHelper
    {
        public static AcceptedRequest GetAcceptedRequestMock()
        {
            return new AcceptedRequest
            {
                Id = 1,
                RequestId = 1,
                UserId = 1,
                Date = DateTime.Now
            };
        }

        public static Request GetRequestMock()
        {
            return new Request
            {
                Id = 1,
                UserId = 1,
                IsAccepted = false,
                Dairy = "Milk",
                Allergens = "None"
            };
        }

        public static User GetUserMock()
        {
            return new User
            {
                Id = 1,
                FirstName = "Lauren",
                LastName = "Miles",
                Email = "lauren.miles@kizan.com",
                PhoneNumber = "1112223333",
                County = "Franklin",
                isAdmin = true,
                Created = DateTime.Now
            };
        }
    }
}
