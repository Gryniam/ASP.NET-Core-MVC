using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Data.Interfaces;
using Forum.Data.EFramework;
using Forum.Models;

namespace Forum.Data
{
    public class InitData
    {
        public static void Initialize(AppDBContent context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Login = "Gryniam",
                        Mail = "muzikaeng@gmail.com",
                        Password = "787898p",
                        RoleId = 0,
                        AdditionalInf = "Put in hu ilo",
                        IsBanned = false,
                        UserRate = 0f,
                        CreatedTopics = 0,
                        AnswersTopics = 0

                    }
                    ) ;
            }
        }
    }
}
