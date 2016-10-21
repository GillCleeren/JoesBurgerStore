using Autofac;
using JoesBurgerStore.Contracts.ViewModels;
using Xamarin.Forms;

namespace JoesBurgerStore.Views
{
    public partial class AboutView : ContentPage
    {
        private IAboutViewModel viewModel;
        public AboutView()
        {
            InitializeComponent();

            viewModel = AppContainer.Container.Resolve<IAboutViewModel>();
            this.BindingContext = viewModel;
        }
    }
}
