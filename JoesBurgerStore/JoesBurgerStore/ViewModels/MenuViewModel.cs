using JoesBurgerStore.Constants;
using JoesBurgerStore.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using JoesBurgerStore.Contracts.ViewModels;
using Xamarin.Forms;

namespace JoesBurgerStore.ViewModels
{
    public class MenuViewModel: ViewModelBase, IMenuViewModel
    {
        private IUserDataService userDataService;
        private INavigationService navigationService;
        public ICommand LoadCommand { get; set; }
        public ICommand OrderBurgersCommand { get; set; }
        public ICommand ViewCartCommand { get; set; }
        public ICommand TakePictureCommand { get; set; }
        public ICommand ViewMapCommand { get; set; }
        public ICommand AboutCommand { get; set; }

        public MenuViewModel(IUserDataService userDataService, INavigationService navigationService)
        {
            this.userDataService = userDataService;
            this.navigationService = navigationService;

            InitializeCommands();
            InitializeMessagingCenter();
        }

        private void InitializeMessagingCenter()
        {
            MessagingCenter.Subscribe<LoginViewModel>(this, "LoginSuccess", async (sender) => 
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await navigationService.PopModalAsync();
                });
            });
        }

        private  void InitializeCommands()
        {
            LoadCommand = new Command(async () =>
            {
                await navigationService.PushModalAsync(PageUrls.LoginView);
            });

            OrderBurgersCommand = new Command(async () =>
            {
                await navigationService.PushAsync(PageUrls.OrderBurgersView);
            });

            ViewCartCommand = new Command(async () =>
            {
                await navigationService.PushAsync(PageUrls.CartView);
            });

            TakePictureCommand = new Command(async () =>
            {
                await navigationService.PushAsync(PageUrls.TakePictureView);
            });

            ViewMapCommand = new Command(async () =>
            {
                await navigationService.PushAsync(PageUrls.ShowMapView);
            });

            AboutCommand = new Command(async () =>
            {
                await navigationService.PushAsync(PageUrls.AboutView);
            });

        }
    }
}
