using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Chat.Models
{
    public class User : IUser
    {
        private string login;
        private string password;

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
