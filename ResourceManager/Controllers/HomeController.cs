using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResourceManager.Controllers
{
    public class HomeController : Controller
    {
        public int StringToInt(string str)
        {
            string numString = new String(str.TakeWhile(Char.IsDigit).ToArray());
            int number = Convert.ToInt32(numString);
            return number;
        }
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good afternoon";

            var data = System.IO.File.ReadAllLines(Server.MapPath("~/App_Data/input3a.data"));
            int processes = StringToInt(data[0]);
            int resources = StringToInt(data[1]);
            ViewBag.ProcessNumber = processes;
            ViewBag.ResourceNumber = resources;
            return View();
        }

        
    }
}