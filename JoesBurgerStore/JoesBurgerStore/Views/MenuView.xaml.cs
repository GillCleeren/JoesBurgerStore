using Autofac;
using JoesBurgerStore.Contracts;
using JoesBurgerStore.Contracts.ViewModels;
using Xamarin.Forms;

namespace JoesBurgerStore.Views
{
    public partial class MenuView : ContentPage
    {
        private IMenuViewModel viewModel;
        private IUserDataService userDataService;
        public MenuView()
        {
            InitializeComponent();
            viewModel = AppContainer.Container.Resolve<IMenuViewModel>();
            userDataService = AppContainer.Container.Resolve<IUserDataService>();
            this.BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (userDataService.LoggedInUser == null)
                viewModel.LoadCommand.Execute(null);
        }
    }
}
