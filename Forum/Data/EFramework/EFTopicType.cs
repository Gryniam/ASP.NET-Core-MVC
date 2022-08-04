using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Forum.Data.Interfaces;
using Forum.Models;

namespace Forum.Data.EFramework
{
    public class EFTopicType : ITopicType
    {
        private readonly AppDBContent context;

        public EFTopicType(AppDBContent context)
        {
            this.context = context;
        }

        public IEnumerable<TopicType> topicTypes => context.TopicTypes;

        public void addType(TopicType topic)
        {
            if(topic.Id == default)
            {
                context.Entry(topic).State = EntityState.Added;
            }
            else
            {
                context.Entry(topic).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public TopicType getTopicType(int id)
        {
            return context.TopicTypes.FirstOrDefault(x => x.Id == id);
        }

        public void removeType(int id)
        {
            foreach(var iterator in context.Topics.Where(x=>x.TopicTypeId == id))
            {
                 iterator.TopicTypeId = topicTypes.FirstOrDefault(x => x.Type == "undefinded").Id;
            }
            context.TopicTypes.Remove(new TopicType() { Id = id });
            context.SaveChanges();
        }
    }
}
