using MVC.Day27.Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MVC.Day27.Assignment.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _dbContext = null;

        public ProductsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Products

        public ActionResult Details()
        {
            //var BookStore = GetNurseryDetails();
            var products = _dbContext.Products.ToList();
            return View(products);//return list of product
        }
        public ActionResult Category(int id)
        {
            var product = _dbContext.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                return View(product);
            }
            return HttpNotFound();
        }
        [HttpGet]
        public ActionResult AddNew()
        {
            var categories = _dbContext.Categories.ToList();
            ViewBag.Categories = categories;
            return View();
        }


        //Data for Product Class
        /*public List<Product> GetNurseryDetails()
        {
            return new List<Product>
            {
                new Product { Id=1, SKU_NO="001", ProductName="Aloevera Plant", Price=449, Description="Its Aloevera Plant", IsAvailable=true},
                new Product { Id=2, SKU_NO="002", ProductName="Rose Plant", Price=459, Description="Its Rose Plant ", IsAvailable=true},
                new Product { Id=3, SKU_NO="003", ProductName="Tulasi Plant", Price=394, Description="Its Tulasi Plant", IsAvailable=true},
                new Product { Id=4, SKU_NO="004", ProductName="Jasmine Plant", Price=234, Description="Its Jasmine Plant ", IsAvailable=false},
            };
        }*/
    }
}