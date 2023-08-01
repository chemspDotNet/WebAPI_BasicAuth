using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_BasicAuth.Models
{
    public class UserRepository
    {
        List<User> _users;
     public  UserRepository()
        {
            _users = new List<User>()
                  {
                      new User() {
                           ID = 101,
                           UserName = "AdminUser",
                           Password = "abc@123",
                           Roles = "Admin",
                           Email = "admin@test.com"
                      },
                     new User() {
                           ID = 102,
                           UserName = "MemberUser",
                           Password = "abc@123",
                           Roles = "Member",
                           Email = "member@test.com"
                      },
                  };
        }

        public List<User> GetUsers()
        {
            return _users;
        }
    }
}