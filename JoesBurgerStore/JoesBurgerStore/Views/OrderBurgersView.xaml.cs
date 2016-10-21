using Autofac;
using JoesBurgerStore.Contracts.ViewModels;
using JoesBurgerStore.Model;
using JoesBurgerStore.ViewModels;
using Xamarin.Forms;

namespace JoesBurgerStore.Views
{
    public partial class OrderBurgersView : ContentPage
    {
        private IOrderBurgersViewModel viewModel;
        public OrderBurgersView()
        {
            InitializeComponent();
            viewModel = AppContainer.Container.Resolve<IOrderBurgersViewModel>();
            this.BindingContext = viewModel;
        }

        
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var orderBurgersViewModel = viewModel as OrderBurgersViewModel;
            orderBurgersViewModel?.LoadCommand.Execute(null);
        }

        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedBurger = e.SelectedItem as Burger;
            viewModel?.BurgerSelectedCommand.Execute(selectedBurger);
        }
    }
}
