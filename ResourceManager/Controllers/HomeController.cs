using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResourceManager.Models;

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

        public Process[] InitializeProcess(int processNum)
        {
            Process[] processArray = new Process[processNum];

            return processArray;
        }

        public Resource[] InitializeResource(int resourceNum)
        {
            Resource[] resourceArray = new Resource[resourceNum];

            return resourceArray;
        }
        
        protected void StartClick(object Source, EventArgs e)
        {
            
        }

        // GET: Home
        public ViewResult Index()
        {
            var data = System.IO.File.ReadAllLines(Server.MapPath("~/App_Data/input3a.data"));

            int processNum = StringToInt(data[0]);
            int resourceNum = StringToInt(data[1]);

            Process[] processArray = new Process[processNum];
            processArray[0] = new Process();

            ViewBag.ProcessNumber = processNum;
            ViewBag.ResourceNumber = resourceNum;

            return View();
        }
    }
}