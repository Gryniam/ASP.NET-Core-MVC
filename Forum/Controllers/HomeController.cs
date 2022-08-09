using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Forum.Data.Interfaces;

namespace Forum.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITopic _topics;
        private readonly IUser _users;

        public HomeController(ITopic topics, IUser users)
        {
            _topics = topics;
            _users = users;
        }

        public ViewResult HomePage()
        {
            return View();
        }
    }
}
