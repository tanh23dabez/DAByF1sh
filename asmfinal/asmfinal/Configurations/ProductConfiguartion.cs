using asmfinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace asmfinal.Configurations;
public class ProductConfiguartion : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).HasColumnType("nvarchar(100)");
        //builder.Property(p => p.Supplier).IsUnicode(true).IsFixedLength().HasMaxLength(100);// nvarchar(100)
    }
}
