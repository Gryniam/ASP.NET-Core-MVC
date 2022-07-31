using Forum.Data.Interfaces;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Forum.Data.EFramework
{
    public class EFUser : IUser
    { 
        private readonly AppDBContent context;

        public EFUser(AppDBContent context)
        {
            this.context = context;
        }
    
        public IEnumerable<User> users => context.Users;

        public void addUser(User user)
        {
            if(user.Id == default)
            {
                context.Entry(user).State = EntityState.Added;

            }
            else
            {
                context.Entry(user).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public User GetUser(Guid id)
        {
            return context.Users.FirstOrDefault(x => x.Id == id);
        }

        public void removeUser(Guid id)
        {
            context.Users.Remove(new User() { Id = id });
            context.SaveChanges();
        }
    }
}
