using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsPortal.Logic;
using NewsPortal.Models;

namespace NewsPortal.Controllers
{
    public class TopicController : Controller
    {
        private TopicManager _topics;
        private NewsManager _news;

        public IActionResult Index(int? id)
        {
            var model = new TopicsNewsModel()
            {
                topics = _topics.GetAll().ToList(),
                news = _news.GetAll().ToList()
            };

            return View();
        }
    }
}