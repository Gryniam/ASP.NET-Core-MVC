using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid CommentId { get; set; }
        public virtual Comment comment { get; set; }
        public Guid CommentUserId { get; set; }
        public virtual User thisUser { get; set; }
        public string Description { get; set; }
    }
}
