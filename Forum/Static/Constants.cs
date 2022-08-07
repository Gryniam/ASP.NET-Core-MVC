using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Models;

namespace Forum.Static
{
    public static class Constants
    {
        public static readonly Role role = new Role { Id = 0, RoleString = "user"};

        public static readonly Category category = new Category { Id = 0, category = "No Category" };

        public static readonly TopicType topicType = new TopicType { Id = 0, Type = "Other" };
    }
}
