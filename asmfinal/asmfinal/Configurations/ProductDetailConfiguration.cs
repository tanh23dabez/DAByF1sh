using asmfinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace asmfinal.Configurations;
public class ProductDetailConfiguration : IEntityTypeConfiguration<ProductDetail>
{
    public void Configure(EntityTypeBuilder<ProductDetail> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Supplier).IsUnicode(true).IsFixedLength().HasMaxLength(100);// nvarchar(100)
        builder.Property(p => p.Description).IsUnicode(true).IsFixedLength().HasMaxLength(100);// nvarchar(100)
        builder.HasOne(p => p.Product).WithMany(p => p.ProductDetails).HasForeignKey(p => p.ProductId);
        builder.HasOne(p => p.Category).WithMany(p => p.ProductDetails).HasForeignKey(p => p.CategoryId);
        builder.HasOne(p => p.Color).WithMany(p => p.ProductDetails).HasForeignKey(p => p.ColorId);
        builder.HasOne(p => p.Material).WithMany(p => p.ProductDetails).HasForeignKey(p => p.MaterialId);
        builder.HasOne(p => p.Size).WithMany(p => p.ProductDetails).HasForeignKey(p => p.SizeId);
    }
}
