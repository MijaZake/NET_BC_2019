using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Advertisements.Logic;
using Advertisements.Models;
using Advertisements.Extensions;

namespace Advertisements.Controllers
{
    public class AccountController : Controller
    {
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
                var user = manager.GetByEmailAndPassword(model.Email, model.Password);

                if(user == null)
                {
                    ModelState.AddModelError("error", "User not found!");
                }
                else
                {
                    HttpContext.Session.SetUserId(user.Id);
                    HttpContext.Session.SetUserEmail(user.Email);

                    TempData["message"] = "User logged in!";
                    return RedirectToAction("Index", "Advertisement");
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
            if (ModelState.IsValid)
            {
                UserManager manager = new UserManager();

                if (manager.GetByEmail(model.Email) != null)
                {
                    ModelState.AddModelError("error", "Email already exists!");
                }
                else
                {
                    manager.Create(new Logic.User()
                    {
                        Email = model.Email,
                        Password = model.Password
                    });

                    TempData["message"] = "User created!";
                    return RedirectToAction("SignIn");
                }
            }
            return View();
        }

        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Advertisement");
        }
    }
}