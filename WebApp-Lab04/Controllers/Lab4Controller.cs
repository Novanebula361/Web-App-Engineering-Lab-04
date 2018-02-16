using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp_Lab04.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {
            DateTime currentDate = DateTime.Now;
            ViewData["Time"] = currentDate.ToShortTimeString();
            ViewData["Date"] = currentDate.ToLongDateString();
            ViewData["DaysLeft"] = (new DateTime(currentDate.Year, 12, 31)).Subtract(currentDate).Days;
            ViewData["Year"] = currentDate.Year;
            return View();
        }

        public IActionResult Page2(int id)
        {
            return View(id);
        }

        public IActionResult Page3()
        {
            ViewData["Header"] = "Beverages";
            String[] beverages = { "Coffee", "Tea", "Coke", "Beer", "Wine", "Vodka" };
            return View(beverages);
        }
    }
}