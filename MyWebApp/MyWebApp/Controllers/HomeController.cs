using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Collins Calculators";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CalcApp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalcApp(string ValA, string ValB, string Op) {
            Console.WriteLine("test Write");
            double value1 = Convert.ToDouble(ValA);
            double value2 = Convert.ToDouble(ValB);
            int selectionType = Convert.ToInt32(Op);
            double result = 0;
            switch (selectionType)
            {
                case 1:
                    result = value1 + value2;
                    break;
                case 2:
                    result = value1 - value2;
                    break;
                case 3:
                    result = value1 * value2;
                    break;
                case 4:
                    result = value1 / value2;
                    break;
                default:
                    Console.WriteLine("Error parsing math");
                    break;
            }
            
 
            return View("CalcApp", (Object)Convert.ToString(result));
        }

    }
}