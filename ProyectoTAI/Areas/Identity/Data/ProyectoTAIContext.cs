using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoTAI.Areas.Identity.Data;

namespace ProyectoTAI.Data;

public class ProyectoTAIContext : IdentityDbContext<ProyectoTAIUser>
{
    public ProyectoTAIContext(DbContextOptions<ProyectoTAIContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApllicationUserEntityConfiguration());
    }
}
public class ApllicationUserEntityConfiguration : IEntityTypeConfiguration<ProyectoTAIUser>
{
    public void Configure(EntityTypeBuilder<ProyectoTAIUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);

    }
}
