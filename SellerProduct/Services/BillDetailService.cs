using SellerProduct.IServices;
using SellerProduct.Models;

namespace SellerProduct.Services;

public class BillDetailService:IBillDetailService
{
    private ShopDbContext context;

    public BillDetailService()
    {
        context = new ShopDbContext();
    }

    public bool CreateBillDetail(BillDetail b)
    {
        try
        {
            context.BillDetails.Add(b);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool DeleteBillDetail(Guid id)
    {
        try
        {
            dynamic bill = context.BillDetails.Find(id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            context.BillDetails.Remove(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public List<BillDetail> GetAllBillDetails()
    {
        return context.BillDetails.ToList();
    }

    public BillDetail GetBillDetailById(Guid id)
    {
        // return context.Products.FirstOrDefault(p => p.Id==id);
        // return context.Products.SingleOrDefault(p => p.Id == id);
        return context.BillDetails.Find(id);
    }

    //public List<BillDetail> GetBillDetailByName(string name)
    //{
    //    return context.Bills.Where(p => p.Name.Contains(name)).ToList();
    //}

    public bool UpdateBillDetail(BillDetail b)
    {
        try
        {
            dynamic bill = context.BillDetails.Find(b.Id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            //bill.Name = b.Name;
            //bill.Status = b.Status;
            context.BillDetails.Update(bill);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
