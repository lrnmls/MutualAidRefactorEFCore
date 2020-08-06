using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MutualAid.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAid.Data.Mapping
{
    public class AcceptedRequestMapping : BaseEntityMapping<AcceptedRequest>
    {
        public override void Configure(EntityTypeBuilder<AcceptedRequest> builder)
        {
            builder.ToTable("Accepted Request");

            base.Configure(builder);
        }
    }
}
