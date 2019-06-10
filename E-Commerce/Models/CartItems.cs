using System;
namespace E_Commerce.Models
{
    public class CartItems
    {
        public int id { get; set; }
        public string cart_guid { get; set; }
        public int product_id { get; set; }
        public int product_quantity { get; set; }
    
    }
}