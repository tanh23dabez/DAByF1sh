using asmfinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace asmfinal.Configurations;

public class BillConfiguration: IEntityTypeConfiguration<Bill>
{
    public void Configure(EntityTypeBuilder<Bill> builder)
    {
        builder.HasKey(p => p.Id); // Thiết lập khóa chính// khóa chính 2 cột
        // Thiết lập cho thuộc tính
        builder.Property(p => p.Status).HasColumnType("int").IsRequired(); // int - not null
        builder.HasOne(p => p.User).WithMany(p => p.Bills).HasForeignKey(p => p.UserId);
    }
}
