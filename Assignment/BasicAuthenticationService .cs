using Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        User user;
        public BasicAuthenticationService(User user)
        {
             this.user = user;
        }
        public bool AuthenticateUser(string username, string password)
        {
            if (user.Username.ToLower() == username.ToLower() && user.Password.ToLower() == password.ToLower()) return true;
            else return false;
        }

        public bool AuthorizeUser( string role)
        {
            if (user.Role.ToLower() == role.ToLower()) return true;
            else return false;
        }
    }
}
