using AdDemo.DataAccess;
using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.UserProfiles
{
  public class UserProfileSqlServerService : IUserProfileRepository
    {
        private readonly AdvertisementDbContext _context = new AdvertisementDbContext();
        public List<UserProfile> AllUserProfiles()
        {
            return _context.UserProfiles.ToList();
        }
        public UserProfile GetAUserProfile(int id)
        {
            return _context.UserProfiles.Find(id);
        }

        public UserProfile AddUserProfile(UserProfile userprofile)
        {
            _context.UserProfiles.Add(userprofile);
            _context.SaveChanges();

            return _context.UserProfiles.Find(userprofile.Id);

        }
        public void UpdateUserProfile(UserProfile userprofile)
        {
            _context.SaveChanges();

        }

        public void DeleteUserProfile(UserProfile userprofile)
        {
            _context.Remove(userprofile);
            _context.SaveChanges();

        }

    }
}
