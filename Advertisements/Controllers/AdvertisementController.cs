using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Advertisements.Extensions;
using Advertisements.Logic;
using Advertisements.Models;
using Microsoft.AspNetCore.Mvc;

namespace Advertisements.Controllers
{
    public class AdvertisementController : Controller
    {
        private CategoryManager _categories;
        private AdvertisementManager _advertisements;
        private AdvertisementsDB _db;

        public AdvertisementController(CategoryManager categoryManager, AdvertisementManager advertisementManager, AdvertisementsDB db)
        {
            _categories = categoryManager;
            _advertisements = advertisementManager;
            _db = db;
        }

        public IActionResult Index()
        {
            var categories = _categories.GetAll();
            foreach (var cat in categories)
            {
                cat.AdvertisementCount = _advertisements.GetByCategory(cat.Id).Count;
            }

            return View(categories);
        }

        public IActionResult Category(int id)
        {
            //all advertisements
            var advertisements = _advertisements.GetAll();
            //if subcategory - all its advertisements added
            var categoryAdvertisements = advertisements.FindAll(a => a.CategoryId == id);

            var categories = _categories.GetAll();
            foreach (Category cat in categories)
            {
                //finds subcategories to this category
                if (cat.CategoryId == id)
                {
                    //finds 
                    List<Advertisement> subcategoryAds = advertisements.FindAll(a => a.CategoryId == cat.CategoryId);
                    categoryAdvertisements.AddRange(subcategoryAds);
                }
            }

            var model = new CatalogModel()
            {
                Advertisements = categoryAdvertisements,
                Category = _categories.Get(id)
            };

            return View(model);
        }

        public IActionResult Advertisement(int id)
        {
            var advertisements = _advertisements.GetAll();
            var ad = advertisements.Find(a => a.Id == id);
            var cat = _categories.Get(ad.CategoryId);

            var model = new AdvertisementModel()
            {
                Advertisement = ad,
                Category = cat
            };

            return View(model);
        }

        public IActionResult New()
        {
            NewModel model = new NewModel();
            model.Email = HttpContext.Session.GetUserEmail();
            model.Categories =_categories.GetAll();

            return View(model);
        }

        [HttpPost]
        public IActionResult New(NewModel model)
        {
            if(ModelState.IsValid)
            {
                //TODO: ieraksta saglabāšana
                var ad = new Logic.Advertisement()
                {
                    Title = model.Title,
                    CategoryId = model.CategoryId,
                    Price = model.Price,
                    Location = model.Location,
                    Phone = model.Phone,
                    Email = model.Email,
                    Description = model.Description,
                    Time = DateTime.Now
                };
                _advertisements.Create(ad);
                model.Categories = _categories.GetAll();

                TempData["message"] = "Advertisement created!";
                return RedirectToAction("Advertisement", new { id = ad.Id});
            }

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            var advertisements = _advertisements.GetAll();
            var userAdvertisements = advertisements.FindAll(a => a.Email == HttpContext.Session.GetUserEmail()).ToList();
            var deleteItem = userAdvertisements.Find(i => i.Id == id);
            _advertisements.Delete(deleteItem.Id);
            _db.SaveChanges();

            return RedirectToAction("MyAdvertisements", "Account");
        }
    }
}