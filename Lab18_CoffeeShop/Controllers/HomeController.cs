using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab18_CoffeeShop.Models;

namespace Lab18_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new RegisterUser());
        }

        [HttpPost]    
        public IActionResult Register(RegisterUser newUser)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ShowRegistration", newUser);
            }
            else
            {
                return View(newUser);
            }
        }
        
        public IActionResult ShowRegistration(RegisterUser user)
        {
            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
