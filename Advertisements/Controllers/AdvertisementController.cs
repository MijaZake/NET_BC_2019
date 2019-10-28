using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Advertisements.Logic;
using Microsoft.AspNetCore.Mvc;

namespace Advertisements.Controllers
{
    public class AdvertisementController : Controller
    {
        public IActionResult Index()
        {
            var categoryManager = new CategoryManager();
            categoryManager.Seed();
            var categories = categoryManager.GetAll();

            return View(categories);
        }
    }
}