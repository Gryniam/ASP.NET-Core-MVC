using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Models;

namespace Forum.Data.Interfaces
{
    interface ITopicType
    {
        IEnumerable<TopicType> topicTypes { get; }

        TopicType getTopicType(int id);

        void addType(TopicType topic);

        void removeType(int id);

    }
}
