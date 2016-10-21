using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using JoesBurgerStore.Model;
using Newtonsoft.Json;

namespace JoesBurgerStore.Repositories
{
    public class WebBurgerRepository
    {
        private static List<BurgerGroup> BurgerGroups = new List<BurgerGroup>();
        public WebBurgerRepository()
        {
            Task.Run(() => this.LoadDataAsync(url)).Wait();
        }

        string url =
           "http://gillcleerenpluralsight.blob.core.windows.net/files/burgers.json";

        private async Task LoadDataAsync(string uri)
        {

            string responseJsonString = null;

            using (var httpClient = new HttpClient())
            {
                try
                {
                    Task<HttpResponseMessage> getResponse = httpClient.GetAsync(uri);

                    HttpResponseMessage response = await getResponse;

                    responseJsonString = await response.Content.ReadAsStringAsync();
                    BurgerGroups = JsonConvert.DeserializeObject<List<BurgerGroup>>(responseJsonString);
                }
                catch (Exception ex)
                {
                    //handle any errors here, not part of the sample app
                    string message = ex.Message;
                }
            }

        }

        public List<Burger> GetAllBurgers()
        {
            IEnumerable<Burger> burgers =
                from burgerGroup in BurgerGroups
                from burger in burgerGroup
                select burger;
            return burgers.ToList<Burger>();
        }

        public Burger GetBurgerById(int BurgerId)
        {
            IEnumerable<Burger> burgers =
                from burgerGroup in BurgerGroups
                from burger in burgerGroup
                where burger.BurgerId == BurgerId
                select burger;

            return burgers.FirstOrDefault();
        }

        public List<BurgerGroup> GetGroupedBurgers()
        {
            return BurgerGroups;
        }

        public List<Burger> GetBurgersForGroup(int BurgerGroupId)
        {
            var group = BurgerGroups.Where(h => h.BurgerGroupId == BurgerGroupId).FirstOrDefault();

            if (group != null)
            {
                return group.ToList();
            }
            return null;
        }

        public List<Burger> GetFavoriteBurgers()
        {
            IEnumerable<Burger> Burgers =
                from BurgerGroup in BurgerGroups
                from Burger in BurgerGroup
                where Burger.IsFavorite
                select Burger;

            return Burgers.ToList<Burger>();
        }
    }
}