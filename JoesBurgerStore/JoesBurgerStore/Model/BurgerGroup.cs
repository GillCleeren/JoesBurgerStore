using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesBurgerStore.Model
{
    public class BurgerGroup: ObservableCollection<Burger>
    {
        public int BurgerGroupId
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string ImagePath
        {
            get;
            set;
        }

        public List<Burger> Burgers
        {
            get;
            set;
        }
    }
}
