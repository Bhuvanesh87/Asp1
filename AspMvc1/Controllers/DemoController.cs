using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMvc1.Controllers
{
    public class DemoController : Controller
    { 
       
        public ViewResult Index()
        {
             ViewData[ "name"] = "Bhuvanesh";
            ViewData["products"] = new List<string>()
            {
                "Samsung Tv" , "Nike shoes","AppleMobile","Smart watch","Wrangler shoes"
            };
            return View();
        }
    }
}