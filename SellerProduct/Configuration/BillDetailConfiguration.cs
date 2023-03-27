using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellerProduct.Models;

namespace SellerProduct.Configuration;

public class BillDetailConfiguration : IEntityTypeConfiguration<BillDetail>
{
    public void Configure(EntityTypeBuilder<BillDetail> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Quantity).IsRequired().HasColumnType("int");
        // set khóa ngoại
        builder.HasOne(p => p.Bill).WithMany(p => p.BillDetails).HasForeignKey(p => p.BillId).HasConstraintName("FK_HD");
        builder.HasOne(p => p.Product).WithMany(p => p.BillDetails).HasForeignKey(p => p.ProductDetailId).HasConstraintName("FK_SP");
    }
}
