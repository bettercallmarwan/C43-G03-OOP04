using C43_G03_OOP04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP04.Classes
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
            => username == "admin" && password == "1111";

        public bool AuthorizeUser(string username, string role)
            => username == "admin" && role == "admin";
    }
}
