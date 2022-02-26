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
        public string Name { get; set; }
        public string UserType { get; set; }
        public string District { get; set; }
    }
}
