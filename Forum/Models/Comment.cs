using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid AnswerId { get; set; }
        public Guid fromUser { get; set; }
        public Guid toUser { get; set; }
        public virtual Comment comment { get; set; }
        public Guid CommentUserId { get; set; }
        public virtual User thisUser { get; set; }
        public string Description { get; set; }
    }
}
