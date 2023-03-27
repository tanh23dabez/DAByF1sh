using SellerProduct.IServices;
using SellerProduct.Models;

namespace SellerProduct.Services;

public class CategoryService : ICategoryService
{
    private ShopDbContext context;

    public CategoryService()
    {
        context = new ShopDbContext();
    }

    public bool CreateCategory(Category b)
    {
        try
        {
            context.Categories.Add(b);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool DeleteCategory(Guid id)
    {
        try
        {
            dynamic bill = context.Categories.Find(id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            context.Categories.Remove(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public List<Category> GetAllCategories()
    {
        return context.Categories.ToList();
    }

    public Category GetCategoryById(Guid id)
    {
        // return context.Products.FirstOrDefault(p => p.Id==id);
        // return context.Products.SingleOrDefault(p => p.Id == id);
        return context.Categories.Find(id);
    }

    public List<Category> GetCategoryByName(string name)
    {
        return context.Categories.Where(p => p.Name.Contains(name)).ToList();
    }

    public bool UpdateCategory(Category b)
    {
        try
        {
            dynamic bill = context.Categories.Find(b.Id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            bill.Name = b.Name;
            bill.Status = b.Status;
            context.Categories.Update(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
