using SellerProduct.IServices;
using SellerProduct.Models;

namespace SellerProduct.Services;

public class BillService : IBillService
{
    private ShopDbContext context;

    public BillService()
    {
        context = new ShopDbContext();
    }

    public bool CreateBill(Bill b)
    {
        try
        {
            context.Bills.Add(b);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool DeleteBill(Guid id)
    {
        try
        {
            dynamic bill = context.Bills.Find(id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            context.Bills.Remove(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public List<Bill> GetAllBills()
    {
        return context.Bills.ToList();
    }

    public Bill GetBillById(Guid id)
    {
        // return context.Products.FirstOrDefault(p => p.Id==id);
        // return context.Products.SingleOrDefault(p => p.Id == id);
        return context.Bills.Find(id);
    }

    //public List<Bill> GetBillByName(string name)
    //{
    //    return context.Bills.Where(p => p.Name.Contains(name)).ToList();
    //}

    public bool UpdateBill(Bill b)
    {
        try
        {
            dynamic bill = context.Bills.Find(b.Id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            //bill.Name = b.Name;
            bill.Status = b.Status;
            context.Bills.Update(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
