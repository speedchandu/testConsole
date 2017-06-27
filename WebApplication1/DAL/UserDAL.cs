using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Misc;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class UserDAL
    {
        MovieStoreEntities db = new MovieStoreEntities();

        public bool IfUserExists(string Username)
        {
            var tmp = db.Users.Where(p => p.UserName == Username).FirstOrDefault();
            if (tmp==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string CreateUser(UserRegistrationViewModel um)
        {
            User u = new User();
            u.Id = Guid.NewGuid().ToString();
            u.UserName = um.UserName;
            u.PasswordHash = Password.sha256(um.Password);
            u.CreatedAt = DateTime.Now;
            u.Status = true;
            u.Roles = 0;

            try
            {
                db.Users.Add(u);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return "Ok";

        }


        public bool Login(UserLoginViewModel um)
        {
            var tmp = db.Users.Where(p => p.UserName == um.UserName).FirstOrDefault();
            if (tmp.PasswordHash==Password.sha256(um.PasswordHash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}