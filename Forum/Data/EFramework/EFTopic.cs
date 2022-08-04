using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Data.Interfaces;
using Forum.Models;
using Microsoft.EntityFrameworkCore;

namespace Forum.Data.EFramework
{
    public class EFTopic : ITopic
    {
        private readonly AppDBContent context;
        public EFTopic(AppDBContent context)
        {
            this.context = context;
        }
        public IEnumerable<Topic> topics => context.Topics;

        public void addTopic(Topic topic)
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

        public Topic getTopic(Guid id)
        {
            return topics.FirstOrDefault(x => x.Id == id);
        }

        public void removeTopic(Guid id)
        {
           foreach(var answer in context.Answer.Where(x=> x.TopicId == id))
           {
                context.Entry(answer).State = EntityState.Deleted;
           }
           context.Topics.Remove(new Topic() { Id = id });
           context.SaveChanges();
        }
    }
}
