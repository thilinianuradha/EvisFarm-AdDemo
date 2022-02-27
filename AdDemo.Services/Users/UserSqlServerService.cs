using AdDemo.DataAccess;
using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.Users
{
    public class UserSqlServerService : IUserRepository
    {
        private readonly AdvertisementDbContext _context = new AdvertisementDbContext();
        public List<User> AllUsers()
        {
            return _context.Users.ToList();
        }
        public User GetAUser(int id)
        {
            return _context.Users.Find(id);
        }

        public User AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return _context.Users.Find(user.Id);

        }
        public void UpdateUser(User user)
        {
            _context.SaveChanges();

        }

        public void DeleteUser(User user)
        {
            _context.Remove(user);
            _context.SaveChanges();

        }
    }
}
