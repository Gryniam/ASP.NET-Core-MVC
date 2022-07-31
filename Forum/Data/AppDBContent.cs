using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Models;
using Microsoft.EntityFrameworkCore;

namespace Forum.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<User> Users {get;set;}
        public DbSet<TopicType> TopicTypes { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<BanStatus> BanStatus { get; set; }
        public DbSet<Answer> Answer { get; set; }

    }
}
