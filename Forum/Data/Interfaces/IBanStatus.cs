using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Models;

namespace Forum.Data.Interfaces
{
    interface IBanStatus
    {
        IEnumerable<BanStatus> banStatuses { get; }

        IQueryable<BanStatus> userBans(Guid UserId);

        BanStatus getBanStatus(Guid id);

        BanStatus getUsersBan(Guid id);

        void setBan(BanStatus status);

        void removeBan(Guid id);
    }
}
