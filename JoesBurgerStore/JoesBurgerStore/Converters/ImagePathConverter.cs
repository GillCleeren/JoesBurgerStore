using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JoesBurgerStore.Converters
{
    public class ImagePathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string imagePath = value.ToString();

            return Device.OnPlatform(
                    FileImageSource.FromUri(new Uri(imagePath)),
                    FileImageSource.FromUri(new Uri(imagePath)),
                    FileImageSource.FromUri(new Uri(imagePath))
                );
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
