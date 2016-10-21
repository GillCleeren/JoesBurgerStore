using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoesBurgerStore.Contracts;
using System.Windows.Input;
using Xamarin.Forms;
using JoesBurgerStore.Constants;
using System.Collections.ObjectModel;
using JoesBurgerStore.Contracts.ViewModels;
using JoesBurgerStore.Model;
using JoesBurgerStore.Extensions;

namespace JoesBurgerStore.ViewModels
{
    public class OrderBurgersViewModel : ViewModelBase, IOrderBurgersViewModel
    {
        private INavigationService navigationService;
        private IUserDataService userDataService;
        private IBurgerDataService burgerDataService;

        public ObservableCollection<Burger> Burgers { get; set; }
        public ObservableCollection<BurgerGroup> BurgerGroups { get; set; }

        public ICommand BurgerSelectedCommand { get; set; }
        public ICommand LoadCommand { get; set; }

        public OrderBurgersViewModel(IUserDataService userDataService, IBurgerDataService burgerDataService, INavigationService navigationService)
        {
            this.userDataService = userDataService;
            this.navigationService = navigationService;
            this.burgerDataService = burgerDataService;

            InitializeCommands();
            //Burgers = burgerDataService.GetAllBurgers().ToObservableCollection();
            BurgerGroups = burgerDataService.GetGroupedBurgers().ToObservableCollection();
        }

        private void InitializeCommands()
        {
            BurgerSelectedCommand = new Command(async(burger) =>
            {
                await navigationService.PushModalAsync(PageUrls.BurgerDetailView, burger);
            });

            LoadCommand = new Command(() =>
            {

            });
        }
    }
}
