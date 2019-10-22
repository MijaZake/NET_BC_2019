using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.logic;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(UserModel model)
        {
            ModelState.Remove("PasswordRepeat");
            if (ModelState.IsValid)
            {
                UserManager manager = new UserManager();
                
                if (manager.GetByEmailAndPassword(model.Email, model.Password) == null)
                {
                    ModelState.AddModelError("error", "User not found!");
                }
                else
                {
                    TempData["message2"] = "User logged in!";
                    return RedirectToAction("Index","Home");
                }
            }

            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            if(ModelState.IsValid)
            {
                UserManager manager = new UserManager();

                if (manager.GetByEmail(model.Email) != null)
                {
                    ModelState.AddModelError("error", "Email already exists!");
                }
                else
                {
                    manager.Create(new logic.User()
                    {
                        Email = model.Email,
                        Password = model.Password,
                    });

                    TempData["message"] = "Account created!";
                    return RedirectToAction("SignIn");
                }
            }

            return View();
        }
    }
}