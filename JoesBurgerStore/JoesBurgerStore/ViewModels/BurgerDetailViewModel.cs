using JoesBurgerStore.Contracts;
using JoesBurgerStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using JoesBurgerStore.Contracts.ViewModels;
using JoesBurgerStore.Dependencies;
using Xamarin.Forms;

namespace JoesBurgerStore.ViewModels
{
    public class BurgerDetailViewModel : ViewModelBase, IBurgerDetailViewModel
    {
        private INavigationService _navigationService;
        private readonly ICartDataService _cartDataService;
        private IUserDataService _userDataService;
        private Burger _selectedBurger;
        private int _amount;
        public ICommand AddToCartCommand { get; set; }
        public ICommand ReadDescriptionCommand { get; set; }


        public int Amount
        {
            get { return _amount; }
            set { _amount = value; OnPropertyChanged("Amount"); }
        }

        public Burger SelectedBurger
        {
            get
            {
                return _selectedBurger;
            }
            set
            {
                _selectedBurger = value;
                OnPropertyChanged("SelectedBurger");
            }
        }

        public BurgerDetailViewModel(IUserDataService userDataService, INavigationService navigationService, ICartDataService cartDataService)
        {
            _userDataService = userDataService;
            _navigationService = navigationService;
            _cartDataService = cartDataService;

            //SelectedBurger = objectToPass as Burger;

            InitializeCommands();
        }

        private void InitializeCommands()
        {
            AddToCartCommand = new Command(() =>
            {
                _cartDataService.AddCartItem(SelectedBurger, Amount);
                _navigationService.PopModalAsync();
            });

            ReadDescriptionCommand = new Command(() =>
            {
                DependencyService.Get<ITextToSpeech>().Read(SelectedBurger.ShortDescription);
            });
        }
    }
}
