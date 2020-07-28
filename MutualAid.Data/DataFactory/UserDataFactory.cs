using MutualAid.Data.Context;
using MutualAid.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAid.Data.DataFactory
{
    public class UserDataFactory : BaseEntityDataFactory<User>
    {
        public UserDataFactory(MutualAidContext mutualAidContext) : base(mutualAidContext)
        {
           
        }

        public override User[] Seed => new[]
        {
            new User()
            {
                Id = 1,
                Email = "lauren.miles@kizan.com",
                FirstName = "Lauren",
                LastName = "Miles",
                PhoneNumber = "9373291424",
                County = "Franklin",
                Password = "Password1",
                Salt = "2xbXMH/6gxk=",
                isAdmin = true,
                Created= DateTime.Now
            }
        };
    }
}
