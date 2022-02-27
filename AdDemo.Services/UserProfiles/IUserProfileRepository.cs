using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.UserProfiles
{
    public interface IUserProfileRepository
    {
        public List<UserProfile> AllUserProfiles();
        public UserProfile GetAUserProfile(int id);
        public UserProfile AddUserProfile(UserProfile userprofile);
        public void UpdateUserProfile(UserProfile userprofile);
        public void DeleteUserProfile(UserProfile userprofile);
    }
}
