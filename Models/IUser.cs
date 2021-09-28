using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Chat.Models
{
    public interface IUser
    {
        string Login { get; set; }
        string Password { get; set; }
    }
}
