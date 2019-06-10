using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using Dapper;
using E_Commerce.Models;

namespace E_Commerce.Repositories
{
    public class CartRepository
    {
        private string connectionString;

        public CartRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<Cart> Get(string guid)
        {
            using (var connection = new SQLiteConnection(this.connectionString))
            {
                //Make it work with the database
                //return connection.Query<Cart>("SELECT cart_items.id, cart_guid, product_id, product_qty, product_name, product_img, product_description from cart_items LEFT JOIN products ON cart_items.product_id = products.id WHERE cart_guid =  @guid", new { guid }).ToList();
            }
        }
    }
}