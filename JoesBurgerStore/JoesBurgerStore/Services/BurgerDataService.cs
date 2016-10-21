using JoesBurgerStore.Contracts;
using JoesBurgerStore.Model;
using JoesBurgerStore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesBurgerStore.Services
{
    public class BurgerDataService: IBurgerDataService
    {
        private static readonly BurgerRepository BurgerRepository = new BurgerRepository();

        public List<Burger> GetAllBurgers()
        {
            return BurgerRepository.GetAllBurgers();
        }

        public List<BurgerGroup> GetGroupedBurgers()
        {
            return BurgerRepository.GetGroupedBurgers();
        }

        public List<Burger> GetBurgersForGroup(int burgerGroupId)
        {
            return BurgerRepository.GetBurgersForGroup(burgerGroupId);
        }

        public List<Burger> GetFavoriteBurgers()
        {
            return BurgerRepository.GetFavoriteBurgers();
        }

        public Burger GetBurgerById(int burgerId)
        {
            return BurgerRepository.GetBurgerById(burgerId);
        }
    }
}
