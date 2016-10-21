using System.ComponentModel;
using JoesBurgerStore.Model;

namespace JoesBurgerStore.Contracts.ViewModels
{
    public interface IBurgerDetailViewModel : INotifyPropertyChanged
    {
        Burger SelectedBurger { get; set; }
    }
}