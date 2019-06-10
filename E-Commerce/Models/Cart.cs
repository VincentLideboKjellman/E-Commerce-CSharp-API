using System;
namespace E_Commerce.Models
{
    public class Cart
    {
        public int id { get; set; }
        public string cart_guid { get; set; }
        public int product_id { get; set; }
        public int product_qty { get; set; }
        public string product_name { get; set; }
    }
}

