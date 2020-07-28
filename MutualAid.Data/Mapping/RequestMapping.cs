using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MutualAid.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAid.Data.Mapping
{
    public class RequestMapping : BaseEntityMapping<Request>
    {
        public override void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.Property(x => x.IsAccepted).HasDefaultValue(false);
            builder.Property(x => x.UserId).IsRequired();

            builder.ToTable("Requests");

            base.Configure(builder);
        }
    }
}
