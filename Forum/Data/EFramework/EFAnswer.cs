using Forum.Data.Interfaces;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Forum.Data.EFramework
{
    public class EFAnswer : IAnswer
    {

        private readonly AppDBContent context;

        private readonly IComment iComment;
        public EFAnswer(AppDBContent context)
        {
            this.context = context;
        }
        public void addAnswer(Answer answer)
        {
            if (answer.Id == default)
            {
                context.Entry(answer).State = EntityState.Added;

            }
            else
            {
                context.Entry(answer).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public Answer getAnswer(Guid id)
        {
            return context.Answers.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Answer> getAnswersFromTopic(Guid id)
        {
            return context.Answers.Where(x => x.TopicId == id);
        }

        public void removeAnswer(Guid id)
        {
            foreach(var com in context.Comments.Where(x=>x.AnswerId == id))
            {
                iComment.removeComment(com.Id);
            }
            context.Answers.Remove(new Answer() { Id = id });
            context.SaveChanges();
        }
    }
}
