using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Models;

namespace Forum.Data.Interfaces
{
    interface ICategory
    {
        IEnumerable<Category> categories { get; }

        Category getCategory(int id);

        void addCategory(Category category);

        void removeCategory(int id);
    }
}
