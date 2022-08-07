using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Models;

namespace Forum.Data.Interfaces
{
    interface IAnswer
    {
        IQueryable<Answer> getAnswersFromTopic(Guid id);

        Answer getAnswer(Guid id);

        void addAnswer(Answer answer);

        void removeAnswer(Guid id);
    }
}
