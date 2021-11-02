using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public DateTime Date;

        public User()
        {
            Date = DateTime.Now;
        }

        public User(string userName, string email, string password): this()
        {
            UserName = userName;
            Email = email;
            Password = password;
        }
    }
}
