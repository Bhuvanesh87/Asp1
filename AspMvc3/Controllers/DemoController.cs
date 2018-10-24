using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspMvc3.Models;

namespace AspMvc3.Controllers
{
    public class DemoController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product{productId=1,productName="Samsung TV",productPrice=40000M},
            new Product{productId=2,productName="Addidas shoes", productPrice=3000}

        };
        public JsonResult ProductsDemo()
        {
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}