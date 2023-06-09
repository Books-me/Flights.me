﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Areas.Identity.Data;

public class FlightsmeDbContext : IdentityDbContext<IdentityUser>
{
    public FlightsmeDbContext(DbContextOptions<FlightsmeDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new FlightsmeUserEntityConfiguration());
    }
}

public class FlightsmeUserEntityConfiguration : IEntityTypeConfiguration<FlightsmeUser>
{
    void IEntityTypeConfiguration<FlightsmeUser>.Configure(EntityTypeBuilder<FlightsmeUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(16);
        builder.Property(u => u.LastName).HasMaxLength(16);
    }
}
