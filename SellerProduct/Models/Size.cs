namespace SellerProduct.Models;

public class Size
{
    public Guid Id { get; set; }
    public int SizeNumber { get; set; }
    public int Status { get; set; }
    public virtual ICollection<Product> Product { get; set; }

}
