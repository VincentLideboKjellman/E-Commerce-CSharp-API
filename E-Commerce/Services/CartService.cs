using System;
using System.Collections.Generic;
using E_Commerce.Repositories;
using E_Commerce.Models;

namespace E_Commerce.Services
{
    public class CartService
    {
        //Dont forget to arr repositories
        private CartRepository cartRepository;

        public CartService(CartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }


        public List<Cart> Get(string guid)
        {
            return this.cartRepository.Get(guid);
        }
    }
}