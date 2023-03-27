using SellerProduct.IServices;
using SellerProduct.Models;

namespace SellerProduct.Services;

public class RoleService:IRoleService
{
    private ShopDbContext context;

    public RoleService()
    {
        context = new ShopDbContext();
    }

    public bool CreateRole(Role b)
    {
        try
        {
            context.Roles.Add(b);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool DeleteRole(Guid id)
    {
        try
        {
            dynamic bill = context.Roles.Find(id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            context.Roles.Remove(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public List<Role> GetAllRoles()
    {
        return context.Roles.ToList();
    }

    public Role GetRoleById(Guid id)
    {
        // return context.Products.FirstOrDefault(p => p.Id==id);
        // return context.Products.SingleOrDefault(p => p.Id == id);
        return context.Roles.Find(id);
    }

    public List<Role> GetRoleByName(string name)
    {
        return context.Roles.Where(p => p.RoleName.Contains(name)).ToList();
    }

    public bool UpdateRole(Role b)
    {
        try
        {
            dynamic bill = context.Roles.Find(b.Id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            bill.Name = b.RoleName;
            bill.Status = b.Status;
            context.Roles.Update(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
