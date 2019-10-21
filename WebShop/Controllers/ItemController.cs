using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.logic;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index(int id)
        {
            var itemManager = new ItemManager();
            itemManager.Seed();
            var categoryManager = new CategoryManager();
            categoryManager.Seed();

            var items = itemManager.GetByCategory(id);
            var categories = categoryManager.GetAll();

            var model = new CatalogModel()
            {
                Items = items,
                Categories = categories
            };

            return View(model);
        }
    }
}