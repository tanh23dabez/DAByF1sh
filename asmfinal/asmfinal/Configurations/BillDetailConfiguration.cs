using asmfinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace asmfinal.Configurations;
    public class BillDetailConfiguration : IEntityTypeConfiguration<BillDetail>
{
    public void Configure(EntityTypeBuilder<BillDetail> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Quantity).IsRequired().HasColumnType("int");
        // set khóa ngoại
        builder.HasOne(p => p.Bill).WithMany(p => p.BillDetails).HasForeignKey(p => p.BillId).HasConstraintName("FK_HD");
        builder.HasOne(p => p.ProductDetail).WithMany(p => p.BillDetails).HasForeignKey(p => p.ProductDetailId).HasConstraintName("FK_SP");
    }
}
