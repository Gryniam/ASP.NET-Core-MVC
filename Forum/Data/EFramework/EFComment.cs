using Forum.Data.Interfaces;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Forum.Data.EFramework
{
    public class EFComment : IComment
    {
        private readonly AppDBContent context;
        public EFComment(AppDBContent context)
        {
            this.context = context;
        }

        public void addComment(Comment comment)
        {
            if (comment.Id == default)
            {
                context.Entry(comment).State = EntityState.Added;

            }
            else
            {
                context.Entry(comment).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public IEnumerable<Comment> comments(Guid id)
        {
            return context.Comments.Where(x => x.AnswerId == id);
        }

        public Comment getComment(Guid id)
        {
            return context.Comments.FirstOrDefault(x => x.Id == id);
        }

        public void removeComment(Guid id)
        {
            context.Comments.Remove(new Comment() { Id = id });
            context.SaveChanges();
        }
    }
}
