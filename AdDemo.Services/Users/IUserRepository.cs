using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.Users
{
    public interface IUserRepository
    {
        public List<User> AllUsers();
        public User GetAUser(int id);
        public User AddUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(User user);
    }
}
