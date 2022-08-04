using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Forum.Models;

namespace Forum.Data.EFramework
{
    public class EFStatus : IStatus
    {
        private readonly AppDBContent context;
        public EFStatus(AppDBContent context)
        {
            this.context = context;
        }

        public void addStatus(Status status)
        {
            if (status.Id == default)
            {
                context.Entry(status).State = EntityState.Added;
            }
            else
            {
                context.Entry(status).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public Status getStatus(int id)
        {
            return context.Status.FirstOrDefault(x => x.Id == id);
        }
    }
}
