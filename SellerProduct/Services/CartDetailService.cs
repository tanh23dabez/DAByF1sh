using SellerProduct.IServices;
using SellerProduct.Models;

namespace SellerProduct.Services;

public class CartDetailService : ICartDetailService
{
    private ShopDbContext context;

    public CartDetailService()
    {
        context = new ShopDbContext();
    }

    public bool CreateCartDetail(CartDetail b)
    {
        try
        {
            context.CartDetails.Add(b);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool DeleteCartDetail(Guid id)
    {
        try
        {
            dynamic bill = context.CartDetails.Find(id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            context.CartDetails.Remove(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public List<CartDetail> GetAllCartDetails()
    {
        return context.CartDetails.ToList();
    }

    public CartDetail GetCartDetailById(Guid id)
    {
        // return context.Products.FirstOrDefault(p => p.Id==id);
        // return context.Products.SingleOrDefault(p => p.Id == id);
        return context.CartDetails.Find(id);
    }

    //public List<CartDetail> GetCartDetailByName(string name)
    //{
    //    return context.Carts.Where(p => p.Name.Contains(name)).ToList();
    //}

    public bool UpdateCartDetail(CartDetail b)
    {
        try
        {
            dynamic bill = context.CartDetails.Find(b.UserId); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            //bill.Name = b.Name;
            //bill.Status = b.Status;
            context.Carts.Update(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
