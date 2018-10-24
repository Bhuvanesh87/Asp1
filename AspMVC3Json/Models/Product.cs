using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace AspMVC3Json.Models
{
    public class Product
    {
        public int productId { set; get; }
        public string productName { set; get; }
        public decimal productPrice { set; get; }
    }
}