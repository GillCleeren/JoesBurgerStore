using Autofac;
using JoesBurgerStore.Contracts.ViewModels;
using JoesBurgerStore.ViewModels;
using Xamarin.Forms;

namespace JoesBurgerStore.Views
{
    public partial class CartView : ContentPage
    {
        private ICartViewModel viewModel;
        public CartView()
        {
            InitializeComponent();
            viewModel = AppContainer.Container.Resolve<ICartViewModel>();

            this.BindingContext = viewModel;
        }
    }
}
