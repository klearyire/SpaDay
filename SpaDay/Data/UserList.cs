using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Data
{
    public class UserList
    {
        static private Dictionary<string, User> ListOfUser { get; set; }

        public static IEnumerable<User> GetAll()
        {
            return ListOfUser.Values;
        }

        public static User GetByUserName(string username)
        {
            return ListOfUser[username];
        }

        public static void AddUser(User username)
        {
            ListOfUser.Add(username.UserName, username);
        }

        public static void RemoveUser(User username)
        {
            ListOfUser.Remove(username.UserName);
        }
    }
}
