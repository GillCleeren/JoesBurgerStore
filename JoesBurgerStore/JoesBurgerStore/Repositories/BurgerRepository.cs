using JoesBurgerStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesBurgerStore.Repositories
{
    public class BurgerRepository
    {
        private static List<BurgerGroup> BurgerGroups;
        static BurgerRepository()
        {
            if (BurgerGroups == null)
            {
                InitializeBurgerGroups();
            }
        }

        private static void InitializeBurgerGroups()
        {
            BurgerGroups = new List<BurgerGroup>();
            var meatLoversGroup = new BurgerGroup() { BurgerGroupId = 1, Title = "Meat lovers", ImagePath = "" };

            meatLoversGroup.Add(new Burger()
            {
                BurgerId = 1,
                Name = "Regular Burger",
                ShortDescription = "The best there is on this planet",
                Description = "Manchego smelly cheese danish fontina. Hard cheese cow goat red leicester pecorino macaroni cheese cheesecake gouda. Ricotta fromage cheese and biscuits stinking bishop halloumi monterey jack cheese strings goat. Pecorino babybel pecorino jarlsberg cow say cheese cottage cheese.",
                ImagePath = "http://gillcleerenpluralsight.blob.core.windows.net/files/hotdog1.jpg",
                Available = true,
                PrepTime = 10,
                Ingredients = new List<string>() { "Regular bun", "Sausage", "Ketchup" },
                Price = 8,
                IsFavorite = true
            });
            meatLoversGroup.Add(new Burger()
            {
                BurgerId = 2,
                Name = "Haute-cuisine Burger",
                ShortDescription = "The classy one",
                Description = "Bacon ipsum dolor amet turducken ham t-bone shankle boudin kevin. Hamburger salami pork shoulder pork chop. Flank doner turducken venison rump swine sausage salami sirloin kielbasa pork belly tail cow. Pork chop bacon ground round cupim tongue, venison frankfurter bresaola tri-tip andouille sirloin turducken spare ribs biltong. Drumstick ham hock pork tail, capicola shank frankfurter beef ribs jowl meatball turkey hamburger. Tenderloin swine ham pork belly beef ribeye. ",
                ImagePath = "http://gillcleerenpluralsight.blob.core.windows.net/files/hotdog2.jpg",
                Available = true,
                PrepTime = 15,
                Ingredients = new List<string>() { "Baked bun", "Gourmet sausage", "Fancy mustard from Germany" },
                Price = 10,
                IsFavorite = false
            });
            meatLoversGroup.Add(new Burger()
            {
                BurgerId = 3,
                Name = "Extra heavy burger",
                ShortDescription = "For when a regular one isn't enough",
                Description = "Capicola short loin shoulder strip steak ribeye pork loin flank cupim doner pastrami. Doner short loin frankfurter ball tip pork belly, shank jowl brisket. Kielbasa prosciutto chuck, turducken brisket short ribs tail pork shankle ball tip. Pancetta jerky andouille chuck salami pastrami bacon pig tri-tip meatball tail bresaola shank short ribs strip steak. Ham hock frankfurter ball tip, biltong cow pastrami swine tenderloin ground round pork loin t-bone. ",
                ImagePath = "http://gillcleerenpluralsight.blob.core.windows.net/files/hotdog3.jpg",
                Available = true,
                PrepTime = 10,
                Ingredients = new List<string>() { "Extra long bun", "Extra long sausage", "More ketchup" },
                Price = 8,
                IsFavorite = true
            });

            BurgerGroups.Add(meatLoversGroup);

            var veggieLoversGroup = new BurgerGroup() { BurgerGroupId = 2, Title = "Veggie lovers", ImagePath = "" };

            veggieLoversGroup.Add(new Burger()
            {
                BurgerId = 4,
                Name = "Veggie Burger",
                ShortDescription = "American for non-meat-lovers",
                Description = "Veggies es bonus vobis, proinde vos postulo essum magis kohlrabi welsh onion daikon amaranth tatsoi tomatillo melon azuki bean garlic.\n\nGumbo beet greens corn soko endive gumbo gourd. Parsley shallot courgette tatsoi pea sprouts fava bean collard greens dandelion okra wakame tomato. Dandelion cucumber earthnut pea peanut soko zucchini.",
                ImagePath = "http://gillcleerenpluralsight.blob.core.windows.net/files/hotdog4.jpg",
                Available = true,
                PrepTime = 10,
                Ingredients = new List<string>() { "Bun", "Vegetarian sausage", "Ketchup" },
                Price = 8,
                IsFavorite = false
            });
            veggieLoversGroup.Add(new Burger()
            {
                BurgerId = 5,
                Name = "Haute Cuisine Veggie Burger",
                ShortDescription = "Classy and veggie",
                Description = "Turnip greens yarrow ricebean rutabaga endive cauliflower sea lettuce kohlrabi amaranth water spinach avocado daikon napa cabbage asparagus winter purslane kale. Celery potato scallion desert raisin horseradish spinach carrot soko. Lotus root water spinach fennel kombu maize bamboo shoot green bean swiss chard seakale pumpkin onion chickpea gram corn pea. Brussels sprout coriander water chestnut gourd swiss chard wakame kohlrabi beetroot carrot watercress. Corn amaranth salsify bunya nuts nori azuki bean chickweed potato bell pepper artichoke.",
                ImagePath = "http://gillcleerenpluralsight.blob.core.windows.net/files/hotdog5.jpg",
                Available = true,
                PrepTime = 15,
                Ingredients = new List<string>() { "Baked bun", "Gourmet vegetarian sausage", "Fancy mustard" },
                Price = 10,
                IsFavorite = true
            });
            veggieLoversGroup.Add(new Burger()
            {
                BurgerId = 6,
                Name = "Extra Heavy Veggie Burger",
                ShortDescription = "For when a regular one isn't enough",
                Description = "Beetroot water spinach okra water chestnut ricebean pea catsear courgette summer purslane. Water spinach arugula pea tatsoi aubergine spring onion bush tomato kale radicchio turnip chicory salsify pea sprouts fava bean. Dandelion zucchini burdock yarrow chickpea dandelion sorrel courgette turnip greens tigernut soybean radish artichoke wattle seed endive groundnut broccoli arugula.",
                ImagePath = "http://gillcleerenpluralsight.blob.core.windows.net/files/hotdog6.jpg",
                Available = true,
                PrepTime = 10,
                Ingredients = new List<string>() { "Extra long bun", "Extra long vegetarian sausage", "More ketchup" },
                Price = 8,
                IsFavorite = false
            });

            BurgerGroups.Add(veggieLoversGroup);
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
