using SellerProduct.Models;

namespace SellerProduct.IServices;

public interface IBillService
{
    public bool CreateBill(Bill b);
    public bool UpdateBill(Bill b);
    public bool DeleteBill(Guid id);
    public List<Bill> GetAllBills();
    public Bill GetBillById(Guid id);
    //public List<Bill> GetBillByName(string name);
}
