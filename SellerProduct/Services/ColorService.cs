using SellerProduct.Models;

namespace SellerProduct.Services;

public class ColorService
{
    private ShopDbContext context;

    public ColorService()
    {
        context = new ShopDbContext();
    }

    public bool CreateColor(Color b)
    {
        try
        {
            context.Colors.Add(b);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool DeleteColor(Guid id)
    {
        try
        {
            dynamic bill = context.Colors.Find(id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            context.Colors.Remove(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public List<Color> GetAllColors()
    {
        return context.Colors.ToList();
    }

    public Color GetColorById(Guid id)
    {
        // return context.Products.FirstOrDefault(p => p.Id==id);
        // return context.Products.SingleOrDefault(p => p.Id == id);
        return context.Colors.Find(id);
    }

    public List<Color> GetColorByName(string name)
    {
        return context.Colors.Where(p => p.Name.Contains(name)).ToList();
    }

    public bool UpdateColor(Color b)
    {
        try
        {
            dynamic bill = context.Colors.Find(b.Id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            bill.Name = b.Name;
            bill.Status = b.Status;
            context.Colors.Update(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
