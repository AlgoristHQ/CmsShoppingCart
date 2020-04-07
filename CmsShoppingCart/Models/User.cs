using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsShoppingCart.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {

        }

        public User(AppUser user)
        {
            UserName = user.UserName;
            Email = user.Email;
            Password = user.PasswordHash;
        }
    }
}
