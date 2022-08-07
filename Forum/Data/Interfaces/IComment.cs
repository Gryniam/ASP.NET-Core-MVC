using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Models;

namespace Forum.Data.Interfaces
{
    interface IComment
    {
        IEnumerable<Comment> comments(Guid id);

        Comment getComment(Guid id);

        void addComment(Comment comment);
        void removeComment(Guid id);

    }
}
