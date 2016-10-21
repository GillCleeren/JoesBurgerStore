using System.ComponentModel;
using System.Windows.Input;

namespace JoesBurgerStore.Contracts.ViewModels
{
    public interface IMenuViewModel : INotifyPropertyChanged
    {
        ICommand LoadCommand { get; set; }
    }
}