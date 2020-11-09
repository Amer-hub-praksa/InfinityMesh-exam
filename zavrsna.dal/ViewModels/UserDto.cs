using zavrsna.dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using LeaveApp.Dal.Domain;

namespace zavrsna.dal.ViewModels
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int age { get; set; }

        public UserDto(User user) 
        {
            Id = User.Id;
            Name = User.Name;
            Email = User.Email;
            age = User.age;
          
        }

    }
}
