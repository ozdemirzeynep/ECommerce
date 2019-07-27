using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (ECommerceContext eCommerceContext = new ECommerceContext())
            {
                List<User> users = eCommerceContext.Users.Include(a => a.Addresses).ToList();
                List<Address> addresses = eCommerceContext.Addresses.Include(a => a.User).ToList();
            }

            return View();
        }
    }
}
