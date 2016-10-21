using JoesBurgerStore.Contracts;
using JoesBurgerStore.Model;
using JoesBurgerStore.Repositories;

namespace JoesBurgerStore.Services
{
    public class CartDataService : ICartDataService
    {
        private static readonly CartRepository CartRepository = new CartRepository();

        public void AddCartItem(Burger burger, int amount)
        {
            CartRepository.AddCartItem(burger, amount);
        }

        public Cart GetCart()
        {
            return CartRepository.GetCart();
        }
    }
}
