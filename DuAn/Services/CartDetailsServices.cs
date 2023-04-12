using DuAn.IServices;
using DuAn.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Xml.Linq;

namespace DuAn.Services
{
    public class CartDetailsServices : ICartDetailsServices
    {
        ShopDbContext Context;
        public CartDetailsServices()
        {
            Context = new ShopDbContext();

        }

        public bool CreateCartDetails(CartDetails p)
        {
            try
            {
                //THEEM 1 DOOI TUONG VAOF DB
                Context.CartDetailss.Add(p);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;

            }
        }

        public bool DeleteCartDetails(Guid idProduct, Guid idUser)
        {
            try
            {
                //Find(id) chi  dung duoc khi id laf khoa chinh
                dynamic cartdetails = Context.CartDetailss.Find(idProduct);//dynamic khiieu du lu naof cung nhan var thi k
                Context.CartDetailss.Remove(cartdetails);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;

            }
        }

        public List<CartDetails> GetAllCartDetailss()
        {
            var list = Context.CartDetailss.ToList();
            if (list == null)
            {
                return new();
            }
            return list;
        }

        public CartDetails GetCartDetailsById(Guid idProduct, Guid idUser)
        {
            var list =  Context.CartDetailss.ToList();
            var obj = list.FirstOrDefault(c => c.UserId == idUser && c.IdSP == idProduct);
            if (obj == null)
            {
                return new CartDetails();
            }
            return obj;
        }

        public List<CartDetails> GetCartDetailsByName(Guid idUser)
        {
            var list = Context.CartDetailss.ToList();
            if (list == null)
            {
                return new();
            }

            list = list.Where(c => c.UserId == idUser).ToList();
            return list;
        }

        public bool UpdateCartDetails(Guid idProduct, Guid idUser, CartDetails obj)
        {
            try
            {
                var listObj = Context.CartDetailss.ToList();
                var cartdetails = listObj.FirstOrDefault(c => c.UserId == idUser && c.IdSP == idProduct);

                cartdetails.Quantity = obj.Quantity;


                Context.CartDetailss.Update(cartdetails);
                 Context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
