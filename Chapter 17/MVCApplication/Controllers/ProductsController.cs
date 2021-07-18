using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> products;

            using (var db = new AdventureWorks2014Entities())
            {
                products = db.Products.ToList();
            }

            return View(products);
        }
    }
}