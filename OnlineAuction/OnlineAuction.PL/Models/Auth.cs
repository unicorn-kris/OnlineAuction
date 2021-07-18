using System.Collections.Generic;
using OnlineAuction.Dependencies;
using OnlineAuction.Entities;

namespace OnlineAuction.PL.Models
{
    public static class Auth
    {
        public static bool IsAuth(string login, string pass)
        {
            var userLogic = DependencyResolver.UserLogic;
            List<User> users = (List<User>)userLogic.GetAll();

            if (login == "admin" && pass == "admin")
            {
                return true;
            }
            else
            {
                foreach (User user in users)
                {
                    if (user.Email == login && user.Password == pass)
                        return true;
                }
                return false;
            }
        }
    }
}