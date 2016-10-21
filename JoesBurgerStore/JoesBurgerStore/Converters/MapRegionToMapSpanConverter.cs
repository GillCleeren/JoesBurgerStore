using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoesBurgerStore.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace JoesBurgerStore.Converters
{
    public class MapRegionToMapSpanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var mapRegionViewModel = value as MapRegionViewModel;
            return mapRegionViewModel != null ? new MapSpan(new Position(mapRegionViewModel.Latitude, mapRegionViewModel.Longitude), mapRegionViewModel.LatitudeDegrees, mapRegionViewModel.LongitudeDegrees) : null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
