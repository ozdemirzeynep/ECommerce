using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class CategoryController : Controller
    {
        [Route("/kategori/{id}")]  //kullanıcının görmesi gerekn adresi veriyoruz
        public IActionResult Index(int id)
        {
            Category category = new Category();

            using (ECommerceContext eCommerceContext = new ECommerceContext())
            {
                category = eCommerceContext.Categories.SingleOrDefault(a => a.Id == id);   // a yı categories olarak alır.
                //select*from Categories where Id==3;  1 tanesini alır
            }
            ViewData["Title"] = category.Name;
            return View(category);
        }
    }
}