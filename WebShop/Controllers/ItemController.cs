using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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

        //1. Pievieno jaunu darbību Buy ar vienu parametru id
        //2. Atlasa lietotāja grozu no sesijas
        //2.1 Ja grozs nav definēts, definē jaunu sarakstu (new List<int>())
        //3. Pievieno izvēleto preces ID lietotāja grozam
        //4. Saglabā lietotāja grozu sesijā

        public IActionResult Buy(int id)
        {
            var basket = HttpContext.Session.GetUserBasket();
            if (basket == null)
            {
                basket = new List<int>();
            }
            basket.Add(id);

            HttpContext.Session.SetUserBasket(basket);

            return RedirectToAction("Index", "Item");
        }

        public IActionResult Basket()
        {
            //1. Definē jaunu sarakstu precēm
            List<Item> items = new List<Item>();
            var basket = HttpContext.Session.GetUserBasket();
            if (basket != null)
            {
                var manager = new ItemManager();
                manager.Seed();
                //2. Par katru preci, kas ir lietotāja sesijā atlasa tās datus un pievieno sarakstam
                foreach (var id in basket)
                {
                    items.Add(manager.Get(id));
                }
            }
            //3. Atgriež preču sarakstu uz View
            return View(items);
        }
    }
}