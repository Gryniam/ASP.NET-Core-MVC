using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Data.Interfaces;
using Forum.Models;
using Microsoft.EntityFrameworkCore;
using Forum.Static;

namespace Forum.Data.EFramework
{
    public class EFCategory : ICategory
    {
        private readonly AppDBContent context;
        public EFCategory(AppDBContent context)
        {
            this.context = context;
        }
        public IEnumerable<Category> categories => context.Categories;

        public void addCategory(Category category)
        {
            if (category.category != Constants.category.category)
            {
                if (category.Id == default)
                {
                    context.Entry(category).State = EntityState.Added;

                }
                else
                {
                    context.Entry(category).State = EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public Category getCategory(int id)
        {
            return context.Categories.FirstOrDefault(x => x.Id == id);
        }

        public void removeCategory(int id)
        {
            if(id != Constants.category.Id)
            {
                foreach(var topic in context.Topics.Where(x=>x.TopicTypeId == id))
                {
                    topic.TopicTypeId = Constants.category.Id;
                }
                context.Categories.Remove(new Category() { Id = id });
                context.SaveChanges();
            }
        }
    }
}
