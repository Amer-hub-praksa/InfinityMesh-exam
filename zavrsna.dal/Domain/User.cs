using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zavrsna.dal.Configuration;

namespace LeaveApp.Dal.Domain
{
    public class User : BaseEntitity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int age { get; set; }
   

        public User()
        {

        }
        public User(User user)
        {
            Id = Guid.NewGuid().GetHashCode();
            Name = user.Name;
            Password = user.Password;
            Email = user.Email;
            age = user.age;

        }
    }
}
