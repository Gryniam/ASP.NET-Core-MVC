using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Forum.Models;
using Forum.Data.Interfaces;
using Forum.Static;

namespace Forum.Data.EFramework
{
    public class EFRole : IRole
    {
        private readonly AppDBContent context;
        public EFRole(AppDBContent context)
        {
            this.context = context;
        }
        public void addRole(Role role)
        {
            if (role.Id == default)
            {
                context.Entry(role).State = EntityState.Added;
            }
            else
            {
                context.Entry(role).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        

        public Role getRole(int id)
        {
            Role role = context.Roles.FirstOrDefault(x => x.Id == id);
            if(role == default)
            {
                return null;
            }
            else
            {
                return role;
            }
        }

        public void removeRole(int id)
        {
            foreach(var user in context.Users.Where(x=> x.RoleId == id))
            {
                user.RoleId = Constants.role.Id;
            }
            context.Roles.Remove(new Role() { Id = id });
            context.SaveChanges();
        }
    }
}
