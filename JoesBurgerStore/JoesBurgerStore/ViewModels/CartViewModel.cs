using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoesBurgerStore.Contracts;
using JoesBurgerStore.Contracts.ViewModels;
using JoesBurgerStore.Extensions;
using JoesBurgerStore.Model;

namespace JoesBurgerStore.ViewModels
{
    public class CartViewModel : ViewModelBase, ICartViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly ICartDataService _cartDataService;
        private readonly IUserDataService _userDataService;

        public ObservableCollection<CartItem> CartItems{ get; set; }

        public CartViewModel(IUserDataService userDataService, INavigationService navigationService, ICartDataService cartDataService)
        {
            _userDataService = userDataService;
            _navigationService = navigationService;
            _cartDataService = cartDataService;

            InitializeData();
        }

        private void InitializeData()
        {
            CartItems = _cartDataService.GetCart().CartItems.ToObservableCollection();
        }
    }
}
