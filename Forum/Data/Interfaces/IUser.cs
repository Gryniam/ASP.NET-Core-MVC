using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Data.Interfaces
{
    public interface IUser
    {
        IEnumerable<User> users { get; }
        User GetUser(Guid id);

        void addUser(User user);
        void removeUser(Guid id);
    }
}
