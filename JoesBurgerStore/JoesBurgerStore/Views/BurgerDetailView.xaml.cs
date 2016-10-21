using Autofac;
using JoesBurgerStore.Contracts.ViewModels;
using JoesBurgerStore.Model;
using Xamarin.Forms;

namespace JoesBurgerStore.Views
{
    public partial class BurgerDetailView : ContentPage
    {
        private IBurgerDetailViewModel viewModel;
        public BurgerDetailView()
        {
            InitializeComponent();
        }

        public BurgerDetailView(object objectToPass)
        {
            InitializeComponent();
            viewModel = AppContainer.Container.Resolve<IBurgerDetailViewModel>();
            viewModel.SelectedBurger = objectToPass as Burger;
            this.BindingContext = viewModel;
        }
    }
}
