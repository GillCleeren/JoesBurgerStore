using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using JoesBurgerStore.Annotations;
using JoesBurgerStore.Contracts;
using JoesBurgerStore.Contracts.ViewModels;
using JoesBurgerStore.ViewModels.Location;

namespace JoesBurgerStore.ViewModels
{
    public class ShowMapViewModel : ViewModelBase, IShowMapViewModel
    {
        private INavigationService navigationService;
        private IUserDataService userDataService;
        private ObservableCollection<ILocationViewModel> _items;

        public ObservableCollection<ILocationViewModel> Items
        {
            get { return _items; }
            set { _items = value; OnPropertyChanged("Items");}
        }

        public ShowMapViewModel(IUserDataService userDataService, INavigationService navigationService)
        {
            this.userDataService = userDataService;
            this.navigationService = navigationService;

            InitializeData();
        }

        private void InitializeData()
        {
            Items = new ObservableCollection<ILocationViewModel>();
            LocationViewModel location1 = new LocationViewModel()
            {
                Title = "Location 1",
                Description = "",
                Longitude = 100,
                Latitude = 100
            };

            LocationViewModel location2= new LocationViewModel()
            {
                Title = "Location 2",
                Description = "",
                Longitude = 50,
                Latitude = 100
            };

            LocationViewModel location3 = new LocationViewModel()
            {
                Title = "Location 3",
                Description = "",
                Longitude = 100,
                Latitude = 50
            };

            Items.Add(location1);
            Items.Add(location2);
            Items.Add(location3);
        }
    }

    public class MapRegionViewModel : INotifyPropertyChanged
    {
        private double _latitude;
        private double _longitude;
        private double _latitudeDegrees;
        private double _longitudeDegrees;

        public double Latitude
        {
            get { return _latitude; }
            set
            {
                _latitude = value;
                OnPropertyChanged();
            }
        }


        public double Longitude
        {
            get { return _longitude; }
            set
            {
                _longitude = value;
                OnPropertyChanged();
            }
        }

        public double LatitudeDegrees
        {
            get { return _latitudeDegrees; }
            set
            {
                _latitudeDegrees = value;
                OnPropertyChanged();
            }
        }

        public double LongitudeDegrees
        {
            get { return _longitudeDegrees; }
            set
            {
                _longitudeDegrees = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
