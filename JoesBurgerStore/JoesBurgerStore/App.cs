using JoesBurgerStore.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using JoesBurgerStore.Contracts;
using Xamarin.Forms;

namespace JoesBurgerStore
{
    public partial class App : Application
    {
        
        public App()
        {
            AppContainer.Container = new Bootstrap().CreateContainer();

            var menuView = new MenuView();

            var navigationService = AppContainer.Container.Resolve<INavigationService>();

            navigationService.Navigation = menuView.Navigation;

            MainPage = new NavigationPage(menuView);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
