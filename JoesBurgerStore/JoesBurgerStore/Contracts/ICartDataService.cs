using JoesBurgerStore.Model;

namespace JoesBurgerStore.Contracts
{
    public interface ICartDataService
    {
        void AddCartItem(Burger burger, int amount);
        Cart GetCart();
    }
}