namespace asmfinal.Models
{
    public class ProductDetail
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid ColorId { get; set; }
        public Guid MaterialId { get; set; }
        public Guid SizeId { get; set; }
        public int Price { get; set; }
        public int AvailableQuantity { get; set; }
        public int Status { get; set; }
        public string Supplier { get; set; }
        public string Description { get; set; }
        public virtual Product Product { get; set; }
        public virtual Category Category { get; set; }
        public virtual Color Color { get; set; }
        public virtual Material Material { get; set; }
        public virtual Size Size { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; }
    }
}
