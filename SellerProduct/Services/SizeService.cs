using SellerProduct.IServices;
using SellerProduct.Models;

namespace SellerProduct.Services;

public class SizeService:ISizeService
{
    private ShopDbContext context;

    public SizeService()
    {
        context = new ShopDbContext();
    }

    public bool CreateSize(Size b)
    {
        try
        {
            context.Sizes.Add(b);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool DeleteSize(Guid id)
    {
        try
        {
            dynamic bill = context.Sizes.Find(id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            context.Sizes.Remove(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public List<Size> GetAllSizes()
    {
        return context.Sizes.ToList();
    }

    public Size GetSizeById(Guid id)
    {
        // return context.Products.FirstOrDefault(p => p.Id==id);
        // return context.Products.SingleOrDefault(p => p.Id == id);
        return context.Sizes.Find(id);
    }

    public List<Size> GetSizeByName(string name)
    {
        return context.Sizes.Where(p => p.SizeNumber == Convert.ToInt32(name)).ToList();
    }

    public bool UpdateSize(Size b)
    {
        try
        {
            dynamic bill = context.Sizes.Find(b.Id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            bill.SizeNumber = b.SizeNumber;
            bill.Status = b.Status;
            context.Sizes.Update(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
