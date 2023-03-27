using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellerProduct.Models;

namespace SellerProduct.Configuration;

public class BillConfiguration : IEntityTypeConfiguration<Bill>
{
    public void Configure(EntityTypeBuilder<Bill> builder)
    {
        //builder.ToTable("HoaDon"); // đặt tên bảng
        builder.HasKey(p => p.Id); // Thiết lập khóa chính
        // builder.HasKey(p => new { p.Id, p.UserId }); // khóa chính 2 cột
        // Thiết lập cho thuộc tính
        builder.Property(p => p.CreateDate).HasColumnType("Date");
        builder.Property(p => p.Status).HasColumnType("int").
            IsRequired(); // int not null
        builder.HasOne(p => p.User).WithMany(p => p.Bills).
            HasForeignKey(p => p.Id).HasConstraintName("FK_Bill_User");
    }
}
