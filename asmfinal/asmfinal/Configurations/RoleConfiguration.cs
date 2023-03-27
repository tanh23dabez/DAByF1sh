using asmfinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace asmfinal.Configurations;
public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.RoleName).HasColumnType("varchar(100)");
        builder.Property(p => p.Description).HasColumnType("nvarchar(1000)");
    }
}
