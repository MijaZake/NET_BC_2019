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
        public IActionResult Index()
        {
            var categoryManager = new CategoryManager();
            categoryManager.Seed();
            var categories = categoryManager.GetAll();

            return View(categories);
        }

        public IActionResult Category(int id)
        {
            var advertisementManager = new AdvertisementManager();
            advertisementManager.Seed();
            //all advertisements
            var advertisements = advertisementManager.GetAll();
            //if subcategory - all its advertisements added
            var categoryAdvertisements = advertisements.FindAll(a => a.CategoryId == id);

            var categoryManager = new CategoryManager();
            categoryManager.Seed();
            var categories = categoryManager.GetAll();
            foreach(Category cat in categories)
            {
                //finds subcategories to this category
                if (cat.CategoryId == id)
                {
                    //finds 
                    List<Advertisement> subcategoryAds = advertisements.FindAll(a => a.CategoryId == cat.CategoryId);
                    categoryAdvertisements.AddRange(subcategoryAds);
                }
            }

            return View(categoryAdvertisements);
        }

        public IActionResult Advertisement(int id)
        {
            var advertisementManager = new AdvertisementManager();
            advertisementManager.Seed();
            var advertisements = advertisementManager.GetAll();
            var ad = advertisements.Find(a => a.Id == id);

            return View(ad);
        }

        public IActionResult New()
        {
            NewModel model = new NewModel();
            CategoryManager categoryManager = new CategoryManager();
            categoryManager.Seed();
            model.Email = HttpContext.Session.GetUserEmail();
            model.Categories = categoryManager.GetAll();

            return View(model);
        }

        [HttpPost]
        public IActionResult New(NewModel model)
        {
            if(ModelState.IsValid)
            {
                //TODO: ieraksta saglabāšana
                AdvertisementManager manager = new AdvertisementManager();
                var ad = new Logic.Advertisement()
                {
                    Title = model.Title,
                    CategoryId = model.CategoryId,
                    Price = model.Price,
                    Location = model.Location,
                    Phone = model.Phone,
                    Email = model.Email,
                    Description = model.Description
                };
                manager.Create(ad);

                TempData["message"] = "Advertisement created!";
                return RedirectToAction("Advertisement", new { id = ad.Id});
            }

            return View(model);
        }
    }
}