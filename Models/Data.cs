using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Chat.Models
{
    public static class Data
    {
        

        public static List<IUser> Users;
        

        static Data()
        {
            Users = new List<IUser>();
            Users.Add(new User("Oleksandr", "password1"));
            Users.Add(new User("Serhii", "password2"));

            
        }
       
    }
}
