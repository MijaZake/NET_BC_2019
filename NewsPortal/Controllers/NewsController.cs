using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NewsPortal.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}