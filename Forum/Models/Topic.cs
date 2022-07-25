using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Models;

namespace Forum.Models
{
    public class Topic
    {
        public Guid Id { get; set; }
        public Guid UserCreateId { get; set; }
        public virtual User user { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TimeOfCreate { get; set; }
        public List<Answer> answers { get; set; }
        public float Rate { get; set; }
        public int StatusId { get; set; }
        public int TopicTypeId { get; set; }
        public int CategoryId { get; set; }
    }
}
