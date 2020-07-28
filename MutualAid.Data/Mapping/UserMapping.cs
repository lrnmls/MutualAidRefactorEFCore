using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MutualAid.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAid.Data.Mapping
{
    public class UserMapping : BaseEntityMapping<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Salt).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired();
            builder.Property(x => x.County).IsRequired();
            builder.Property(x => x.isAdmin).HasDefaultValue(false);
            builder.Property(x => x.Created).ValueGeneratedOnAdd();

            builder.ToTable("Users");

            builder.HasData(
                new User
                {
                    Id = 1,
                    Email = "lauren.miles@kizan.com",
                    FirstName = "Lauren",
                    LastName = "Miles",
                    PhoneNumber = "9373291424",
                    County = "Franklin",
                    Password = "cbpwtZPsJD3FWtBrCS37LF8NMKc=",
                    Salt = "ItM0F+lRxK4=",
                    isAdmin = true,
                    Created = DateTime.Now
                });

            base.Configure(builder);
        }
    }
}
