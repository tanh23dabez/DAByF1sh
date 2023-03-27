using SellerProduct.Models;

namespace SellerProduct.IServices;

public interface ICartDetailService
{
    public bool CreateCartDetail(CartDetail b);
    public bool UpdateCartDetail(CartDetail b);
    public bool DeleteCartDetail(Guid id);
    public List<CartDetail> GetAllCartDetails();
    public CartDetail GetCartDetailById(Guid id);
    //public List<CartDetail> GetCartDetailByName(string name);
}
