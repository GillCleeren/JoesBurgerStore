using JoesBurgerStore.Contracts;
using JoesBurgerStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using JoesBurgerStore.Contracts.ViewModels;
using Plugin.Connectivity;
using Xamarin.Forms;

namespace JoesBurgerStore.ViewModels
{
    public class LoginViewModel: ViewModelBase, ILoginViewModel
    {
        private IUserDataService userDataService;
        private INavigationService navigationService;
         
        public string Username { get; set; }

        public string Password { get; set; }

        public string ValidationErrors { get; private set; }

        public ICommand LoginCommand { get; set; }

        public ICommand HelpCommand { get; set; }

        public bool CanLogin
        {
            get
            {
                ValidationErrors = string.Empty;

                if (string.IsNullOrEmpty(Username))
                    ValidationErrors = "Please enter a username.";

                if (string.IsNullOrEmpty(Password))
                    ValidationErrors += "Please enter a password.";

                return string.IsNullOrEmpty(ValidationErrors);
            }
        }

        public LoginViewModel(IUserDataService userDataService, INavigationService navigationService)
        {
            this.userDataService = userDataService;
            this.navigationService = navigationService;

            InitializeCommands();
        }

        private void InitializeCommands()
        {
            this.LoginCommand = new Command(() =>
            {
                if (CanLogin)
                {
                    if (CrossConnectivity.Current.IsConnected)
                    {
                        userDataService.LoginAsync(Username, Password).ContinueWith((a) =>
                        {
                            MessagingCenter.Send<LoginViewModel>(this, "LoginSuccess");
                        });
                    }
                }
            });
        }
    }
}
