using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Models;

namespace Forum.Data.Interfaces
{
    public interface ITopic
    {
        IEnumerable<Topic> topics { get; }

        Topic getTopic(Guid id);

        void addTopic(Topic topic);

        void removeTopic(Guid id);
    }
}
