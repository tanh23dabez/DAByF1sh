using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace SellerProduct.Models;

public class ShopDbContext : DbContext
{
    public ShopDbContext() { }
    public ShopDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Material> Materials { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Bill> Bills { get; set; }
    public DbSet<BillDetail> BillDetails { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartDetail> CartDetails { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Size> Sizes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-K48S9DA;Initial Catalog=ccauthentic;Persist Security Info=True;User ID=anhpt123;Password=anhpt123");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
