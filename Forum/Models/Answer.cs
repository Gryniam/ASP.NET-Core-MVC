using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Answer
    {
        public Guid Id { get; set; }
        public Guid TopicId { get; set; }
        public Guid AnswerUser { get; set; }
        public List<Comment> comments { get; set; }
        public string Description { get; set; }
        public DateTime TimeOfCreate { get; set; }

    }
}
