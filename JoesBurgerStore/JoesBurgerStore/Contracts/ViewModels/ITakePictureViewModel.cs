using System.ComponentModel;
using Xamarin.Forms;

namespace JoesBurgerStore.Contracts.ViewModels
{
    public interface ITakePictureViewModel : INotifyPropertyChanged
    {
        ImageSource ImageSource { get; set; }
    }
}