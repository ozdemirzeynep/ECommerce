using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class ProductController : Controller
    {
        [Route("/urun/{id}")]
        public IActionResult Index(int id)
        {
            Models.Product product;
            using(ECommerceContext eCommerceContext = new ECommerceContext())
            {
                product = eCommerceContext.Products.SingleOrDefault(a => a.Id == id);
            }
            return View(product);
        }

        public IActionResult Update(int id)
        {
            Models.Product product;
            using (ECommerceContext eCommerceContext = new ECommerceContext())
            {
                product = eCommerceContext.Products.SingleOrDefault(a => a.Id == id);
            }
            return View(product);
            
        }
    }
}