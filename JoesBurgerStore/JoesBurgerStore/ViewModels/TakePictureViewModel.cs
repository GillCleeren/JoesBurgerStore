using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using JoesBurgerStore.Contracts;
using JoesBurgerStore.Contracts.ViewModels;
using Xamarin.Forms;

namespace JoesBurgerStore.ViewModels
{
    public class TakePictureViewModel : ViewModelBase, ITakePictureViewModel
    {
        private INavigationService _navigationService;
        private readonly ICameraService _cameraSerivce;
        private IUserDataService _userDataService;
        public ICommand TakePictureCommand { get; set; }

        private ImageSource _imageSource;

        public ImageSource ImageSource
        {
            get
            {
                return _imageSource;
            }
            set
            {
                _imageSource = value;
                OnPropertyChanged("ImageSource");
            }
        }

        public TakePictureViewModel(IUserDataService userDataService, INavigationService navigationService, ICameraService cameraSerivce)
        {
            _userDataService = userDataService;
            _navigationService = navigationService;
            _cameraSerivce = cameraSerivce;

            InitializeCommands();
        }

        private void InitializeCommands()
        {
            TakePictureCommand = new Command(async () =>
            {
                var mediaFile = await _cameraSerivce.TakePicture();
                ImageSource = ImageSource.FromStream(() => mediaFile.Source);
            });
        }
    }
}
