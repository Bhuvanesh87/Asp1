using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspMVC3Json.Models;

namespace AspMVC3Json.Controllers
{
    public class DemoController : Controller
    {  
        List<Product> products = new List<Product>()
        {
            new Product{productId=1,productName="Apple TV", productPrice=80000M},
            new Product{productId=2,productName="Nike shoe",productPrice=3000M},
            new Product{productId=3,productName="Samsung mobile",productPrice=15000M},
            new Product{productId=4,productName="Apple laptop",productPrice=150000M},
            new Product{productId=5,productName="Yamaha Bike",productPrice=75000M},
            new Product{productId=6,productName="wrangler watch",productPrice=5000M},
        };
        public JsonResult ProductsData()
        {
            return Json(products,JsonRequestBehavior.AllowGet);
        }
    }
}