﻿namespace asmfinal.Models
{
    public class BillDetail
    {
        public Guid Id { get; set; }
        public Guid BillId { get; set; }
        public Guid ProductDetailId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public virtual Bill Bill { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }
    }
}
