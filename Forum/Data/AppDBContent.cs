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
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BanStatus> BanStatus { get; set; }
        public DbSet<Answer> Answers { get; set; }

    }
}
