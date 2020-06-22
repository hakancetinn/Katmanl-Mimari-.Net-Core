using Demo.Nothwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Northwind.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }
}
