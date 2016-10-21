using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesBurgerStore.Model
{
    public class CartItem
    {
        public Burger Burger { get; set; }
        public int Amount { get; set; }
    }
}
