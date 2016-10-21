using JoesBurgerStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesBurgerStore.Contracts
{
    public interface IUserDataService
    {
        User SearchUser(string userName);

        Task LoginAsync(string userName, string password);

        User LoggedInUser { get; set; }
    }
}
