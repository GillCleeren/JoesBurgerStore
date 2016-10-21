using JoesBurgerStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using JoesBurgerStore.Contracts;
using JoesBurgerStore.Contracts.ViewModels;
using Xamarin.Forms;

namespace JoesBurgerStore.Views
{
    public partial class TakePictureView : ContentPage
    {
        private readonly ITakePictureViewModel viewModel;
        public TakePictureView()
        {
            InitializeComponent();
            viewModel = AppContainer.Container.Resolve<ITakePictureViewModel>();
            this.BindingContext = viewModel;

            viewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ImageSource")
            {
                TakePictureImage.Source = viewModel.ImageSource;
            }
        }
    }
}
