using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab18_CoffeeShop.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Lab18_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        List<RegisterUser> userList = new List<RegisterUser>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddUserToList(RegisterUser user)
        {
            string userJson = HttpContext.Session.GetString("RegisterUserSession");
            if(userJson != null)
            {
                userList = JsonConvert.DeserializeObject<List<RegisterUser>>(userJson);
            }

            userList.Add(user);
            HttpContext.Session.SetString("RegisterUserSession", JsonConvert.SerializeObject(userList));
            return View(userList);
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
                string userJson = HttpContext.Session.GetString("RegisterUserSession");
                if (userJson != null)
                {
                    userList = JsonConvert.DeserializeObject<List<RegisterUser>>(userJson);
                }
                userList.Add(newUser);
                HttpContext.Session.SetString("RegisterUserSession",JsonConvert.SerializeObject(userList));
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
