using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Models;

namespace Forum.Data.Interfaces
{
    public interface IStatus
    {
        Status getStatus(int id);
        void addStatus(Status status);
    }
}
