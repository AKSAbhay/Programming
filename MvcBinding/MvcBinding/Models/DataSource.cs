using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBinding.Models
{
    public class DataSource
    {
        public IEnumerable<User> /*User*/ Users
        {
            get
            {
                List<User> users = new List<User>()
                {
                    new User{UserName="Abhay",Password="123"}
                };
            return users;
            }
            
        }
    }
}