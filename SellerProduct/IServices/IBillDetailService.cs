using SellerProduct.Models;

namespace SellerProduct.IServices;

public interface IBillDetailService
{
    public bool CreateBillDetail(BillDetail b);
    public bool UpdateBillDetail(BillDetail b);
    public bool DeleteBillDetail(Guid id);
    public List<BillDetail> GetAllBillDetails();
    public BillDetail GetBillDetailById(Guid id);
    //public List<BillDetail> GetBillDetailByName(string name);
}
