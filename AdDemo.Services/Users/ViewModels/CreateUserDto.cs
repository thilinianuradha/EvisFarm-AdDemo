using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.Users.ViewModels
{
    public class CreateUserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public char Password { get; set; }
    }
}
