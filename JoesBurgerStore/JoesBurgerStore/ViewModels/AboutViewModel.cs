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
    public class AboutViewModel : ViewModelBase, IAboutViewModel
    {
        private INavigationService _navigationService;
        private IUserDataService _userDataService;
        private string _general;
        private string _copyright;
        private string _moreInfo;
        //private string _link;

        public string General
        {
            get { return _general; }
            set { _general = value; OnPropertyChanged("General"); }
        }

        public string Copyright
        {
            get { return _copyright; }
            set { _copyright = value; OnPropertyChanged("Copyright"); }
        }

        public string MoreInfo
        {
            get { return _moreInfo; }
            set { _moreInfo = value; OnPropertyChanged("MoreInfo"); }
        }

        public ICommand MoreInfoCommand { get; set; }

        public AboutViewModel(IUserDataService userDataService, INavigationService navigationService)
        {
            _userDataService = userDataService;
            _navigationService = navigationService;

            InitializeData();
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            MoreInfoCommand = new Command(() =>
            {
                Device.OpenUri(new Uri("http://www.google.be"));
            });
        }

        private void InitializeData()
        {
            //TODO: get from resx
            General = "App from Joe's Hamburgers";
            Copyright = "Copyright 2016 Joe - All rights reserved";
            MoreInfo = "Visit us on our website";
            
        }
    }
}
