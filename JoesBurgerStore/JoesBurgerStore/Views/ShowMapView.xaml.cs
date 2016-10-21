using JoesBurgerStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using JoesBurgerStore.Contracts.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace JoesBurgerStore.Views
{
    public partial class ShowMapView : ContentPage
    {
        private readonly IShowMapViewModel viewModel;
        public ShowMapView()
        {
            InitializeComponent();
            viewModel = AppContainer.Container.Resolve<IShowMapViewModel>();
            this.BindingContext = viewModel;
        }
    }
}
