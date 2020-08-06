using MutualAid.Application.Services;
using MutualAidRefactorEFCore.Data.DTO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAid.Application.UnitTest.ServicesTests
{
    public class UsersTests
    {
        [Test]
        public void Get_User_By_UserId_Test()
        {
            var userDto = new UserDto
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
