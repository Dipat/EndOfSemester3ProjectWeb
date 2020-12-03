using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClient22.caller;
using WebClient22.Models;

namespace WebClient22.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MainPage(string username, string password)
        {
            var caller = new RestSharpCaller("https://localhost:44358/api/");
            if (caller.LogIn(username, password)==true)
                {
                var listProducts = caller.GetProducts();
             
                return View(listProducts);
            }
            else
            {
                return View("/Views/Home/Login.cshtml");
            }
        }
    }
}