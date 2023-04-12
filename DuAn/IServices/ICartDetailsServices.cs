using DuAn.Models;

namespace DuAn.IServices
{
    public interface ICartDetailsServices
    {
        public bool CreateCartDetails(CartDetails p);
        public bool UpdateCartDetails(Guid idProduct, Guid idUser, CartDetails obj);
        public bool DeleteCartDetails(Guid idProduct, Guid idUser);
        public List<CartDetails> GetAllCartDetailss();
        public CartDetails GetCartDetailsById(Guid idProduct, Guid idUser);
        public List<CartDetails> GetCartDetailsByName(Guid idUser);
    }
}
