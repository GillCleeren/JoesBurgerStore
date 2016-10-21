using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JoesBurgerStore.ViewModels.Location
{
    public interface ILocationViewModel
    {
        string Title { get; set; }
        string Description { get; set; }
        double Latitude { get; set; }
        double Longitude { get; set; }
    }

    class LocationViewModel : ILocationViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}
