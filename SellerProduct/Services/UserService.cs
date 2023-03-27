using SellerProduct.IServices;
using SellerProduct.Models;

namespace SellerProduct.Services;

public class UserService:IUserService
{
    private ShopDbContext context;

    public UserService()
    {
        context = new ShopDbContext();
    }

    public bool CreateUser(User b)
    {
        try
        {
            context.Users.Add(b);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool DeleteUser(Guid id)
    {
        try
        {
            dynamic bill = context.Users.Find(id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            context.Users.Remove(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public List<User> GetAllUsers()
    {
        return context.Users.ToList();
    }

    public User GetUserById(Guid id)
    {
        // return context.Products.FirstOrDefault(p => p.Id==id);
        // return context.Products.SingleOrDefault(p => p.Id == id);
        return context.Users.Find(id);
    }

    public List<User> GetUserByName(string name)
    {
        return context.Users.Where(p => p.Username.Contains(name)).ToList();
    }

    public bool UpdateUser(User b)
    {
        try
        {
            dynamic bill = context.Users.Find(b.Id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            bill.Username = b.Username;
            bill.Status = b.Status;
            context.Users.Update(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
