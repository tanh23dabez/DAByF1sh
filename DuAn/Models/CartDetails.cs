﻿namespace DuAn.Models
{
    public class CartDetails
    {
        public  Guid Id { get; set; }   
        public Guid UserId { get; set; } // có thể null
        public Guid IdSP { get; set; }
        public int  Quantity { get; set; }
        public virtual Product Product { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
