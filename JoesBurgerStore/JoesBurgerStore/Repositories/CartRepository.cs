using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoesBurgerStore.Model;

namespace JoesBurgerStore.Repositories
{
    public class CartRepository
    {
        static readonly Cart MainCart = new Cart() { CartItems = new List<CartItem>() };

        public void AddCartItem(Burger burger, int amount)
        {
            MainCart.CartItems.Add(new CartItem() { Burger = burger, Amount = amount });
        }

        public Cart GetCart()
        {
            return MainCart;
        }
    }
}
