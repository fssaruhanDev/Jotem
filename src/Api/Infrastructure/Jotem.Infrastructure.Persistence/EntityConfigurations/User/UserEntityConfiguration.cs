using System;
using Jotem.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Infrastructure.Persistence.EntityConfigurations.User;

public class UserEntityConfiguration : BaseEntityConfiguration<Jotem.Api.Domain.Models.User>
{
    public override void Configure(EntityTypeBuilder<Jotem.Api.Domain.Models.User> builder)
    {
        base.Configure(builder);

        builder.ToTable("user", EntityContext.DEFAULT_SCHEMA);
    }
}

