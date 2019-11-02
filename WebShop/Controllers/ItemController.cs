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
        private CategoryManager _categories;
        private ItemManager _items;
        public ItemController(CategoryManager categoryManager, ItemManager itemManager)
        {
            _categories = categoryManager;
            _items = itemManager;
        }

        public IActionResult Index(int id)
        {
            var items = _items.GetByCategory(id);
            var categories = _categories.GetAll();
            foreach(var cat in categories)
            {
                //atlasa un uzstada precu skaitu zem konkretas kategorijas
                cat.ItemCount = _items.GetByCategory(cat.Id).Count;
            }

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

            var item = _items.Get(id);

            return RedirectToAction("Index", "Item", new { id = item.CategoryId });
        }

        public IActionResult Basket()
        {
            //1. Definē jaunu sarakstu precēm
            List<Item> items = new List<Item>();
            var basket = HttpContext.Session.GetUserBasket();
            if (basket != null)
            {
                //2. Par katru preci, kas ir lietotāja sesijā atlasa tās datus un pievieno sarakstam
                foreach (var id in basket)
                {
                    items.Add(_items.Get(id));
                }
            }
            //3. Atgriež preču sarakstu uz View
            return View(items);
        }

        public IActionResult Delete(int id)
        {
            var basket = HttpContext.Session.GetUserBasket();
            var deleteItem = basket.Find(i => i == id);
            basket.Remove(deleteItem);

            HttpContext.Session.SetUserBasket(basket);

            return RedirectToAction("Basket");
        }
    }
}