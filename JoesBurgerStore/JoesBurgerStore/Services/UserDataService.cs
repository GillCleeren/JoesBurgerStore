using JoesBurgerStore.Contracts;
using JoesBurgerStore.Model;
using JoesBurgerStore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesBurgerStore.Services
{
    public class UserDataService: IUserDataService
    {
        private static UserRepository userRepository = new UserRepository();

        public User LoggedInUser { get; set; }

        public Task LoginAsync(string userName, string password)
        {
            return Task.Factory.StartNew(() =>
            {
                LoggedInUser = new User {UserName = userName};
            });
        }

        public User SearchUser(string userName)
        {
            return userRepository.SearchUser(userName);
        }
    }
}
