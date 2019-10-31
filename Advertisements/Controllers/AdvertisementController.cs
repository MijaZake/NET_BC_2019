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

        public IActionResult Category(int id)
        {
            var advertisementManager = new AdvertisementManager();
            advertisementManager.Seed();
            //all advertisements
            var advertisements = advertisementManager.GetAll();
            //advertisements in category - subcategory advertisements added
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
    }
}