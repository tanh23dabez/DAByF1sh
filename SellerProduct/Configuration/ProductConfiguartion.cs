using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellerProduct.Models;

namespace SellerProduct.Configuration;

public class ProductConfiguartion : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);//thiết lập khóa chính
        builder.Property(p => p.Name).HasColumnType("nvarchar(100)");

        //builder.Property(p => p.Supplier).HasColumnType("navchar(100)");
        builder.Property(p => p.Supplier).IsUnicode(true).IsFixedLength().HasMaxLength(100);//navchar(100)
        builder.Property(x => x.Description).HasColumnType("nvarchar(100)");

    }
}
