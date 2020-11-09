using LeaveApp.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using zavrsna.dal.ViewModels;

namespace LeaveApp.Dal.ViewModels
{
    public class UserViewModel
    {
        public IReadOnlyCollection<UserDto> Collection { get; }
        public UserViewModel(IReadOnlyCollection<User> Users)
        {
            Collection = Users.Select(user => new UserDto(user)).ToList();
        }
    }
}