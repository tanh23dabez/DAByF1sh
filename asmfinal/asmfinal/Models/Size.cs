namespace asmfinal.Models
{
    public class Size
    {
        public Guid Id { get; set; }
        public int SizeNumber { get; set; }
        public int Status { get; set; }
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
