using SellerProduct.IServices;
using SellerProduct.Models;

namespace SellerProduct.Services;

public class CartService : ICartService
{
    private ShopDbContext context;

    public CartService()
    {
        context = new ShopDbContext();
    }

    public bool CreateCart(Cart b)
    {
        try
        {
            context.Carts.Add(b);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool DeleteCart(Guid id)
    {
        try
        {
            dynamic bill = context.Carts.Find(id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            context.Carts.Remove(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public List<Cart> GetAllCarts()
    {
        return context.Carts.ToList();
    }

    public Cart GetCartById(Guid id)
    {
        // return context.Products.FirstOrDefault(p => p.Id==id);
        // return context.Products.SingleOrDefault(p => p.Id == id);
        return context.Carts.Find(id);
    }

    //public List<Cart> GetCartByName(string name)
    //{
    //    return context.Carts.Where(p => p.Name.Contains(name)).ToList();
    //}

    public bool UpdateCart(Cart b)
    {
        try
        {
            dynamic bill = context.Carts.Find(b.UserId); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
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
