using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Models;

namespace Forum.Data.Interfaces
{
    public interface IRole
    {
        Role getRole(int id);
        void addRole(Role role);
        void removeRole(int id);
    }
}
