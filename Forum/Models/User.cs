using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string AdditionalInf { get; set; }
        public bool IsBanned { get; set; }
        public float UserRate { get; set; }
        public int CreatedTopics { get; set; }
        public int AnswersTopics { get; set; }
    }
}
