using Autofac;
using JoesBurgerStore.Contracts.ViewModels;
using Xamarin.Forms;

namespace JoesBurgerStore.Views
{
    public partial class LoginView : ContentPage
    {
        private ILoginViewModel viewModel;

        public LoginView()
        {
            InitializeComponent();
            viewModel = AppContainer.Container.Resolve<ILoginViewModel>();

            this.BindingContext = viewModel;
        }
    }
}
