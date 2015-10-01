using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;

namespace LetterCount.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //[HttpPost]
        //public ActionResult Find(string text) {
        //    Hashtable table = new Hashtable();

        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if(table.ContainsKey(text[i]) {
        //            table.Add(text[i], (int)table[text[i]] + 1);
        //        }
        //        else {
        //            table.Add(text[i], 1);
        //        }
        //    }
        //    return View("Index");
        //}
    }
}
