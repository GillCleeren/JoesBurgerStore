using JoesBurgerStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesBurgerStore.Contracts
{
    public interface IBurgerDataService
    {
        List<Burger> GetAllBurgers();

        List<BurgerGroup> GetGroupedBurgers();

        List<Burger> GetBurgersForGroup(int burgerGroupId);

        List<Burger> GetFavoriteBurgers();

        Burger GetBurgerById(int burgerId);
    }
}
