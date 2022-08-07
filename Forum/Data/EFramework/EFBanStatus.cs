using Forum.Data.Interfaces;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Forum.Data.EFramework
{
    public class EFBanStatus : IBanStatus
    {
        private readonly AppDBContent context;
        public EFBanStatus(AppDBContent context)
        {
            this.context = context;
        }
        public IEnumerable<BanStatus> banStatuses => context.BanStatus;

        public IQueryable<BanStatus> userBans(Guid UserId)
        {
            return context.BanStatus.Where(x => x.UserId == UserId);
        }

        public BanStatus getBanStatus(Guid id)
        {
            return context.BanStatus.FirstOrDefault(x => x.Id == id);
        }


        public BanStatus getUsersBan(Guid id)
        {
            return context.BanStatus.FirstOrDefault(x => x.UserId == id);
        }


        public void removeBan(Guid id)
        {
            
        }

        public void setBan(BanStatus status)
        {
            
        }

       
    }
}
