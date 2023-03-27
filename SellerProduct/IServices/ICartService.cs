using SellerProduct.Models;

namespace SellerProduct.IServices;

public interface ICartService
{
    public bool CreateCart(Cart b);
    public bool UpdateCart(Cart b);
    public bool DeleteCart(Guid id);
    public List<Cart> GetAllCarts();
    public Cart GetCartById(Guid id);
    //public List<Cart> GetCartByName(string name);
}
