using JoesBurgerStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesBurgerStore.Repositories
{
    public class UserRepository
    {
        private static List<User> knownUsers = new List<User>()
        {
            new User() { UserName = "gillcleeren", Password="123456"},
            new User() { UserName = "someuser", Password="123456"}
        };

        public User SearchUser(string userName)
        {
            return knownUsers.Where(u => u.UserName == userName).FirstOrDefault();
        }
    }
}
