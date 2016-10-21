using System.ComponentModel;
using System.Windows.Input;

namespace JoesBurgerStore.Contracts.ViewModels
{
    public interface IOrderBurgersViewModel : INotifyPropertyChanged
    {
        ICommand BurgerSelectedCommand { get; set; }
    }
}