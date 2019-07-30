using Microsoft.AspNetCore.Mvc;
using System;

using System.Linq;

namespace ECommerce.Controllers
{
    public class AjaxController : Controller
    {
        [Route("/api")]
        public IActionResult Handle()
        {
            string json = HttpContext.Request.Form["JSON"].ToString();
            DTO.ProductSaveDto productSave = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO.ProductSaveDto>(json);

            using (ECommerceContext eCommerceContext = new ECommerceContext())
            {
                eCommerceContext.Products.Add(new Models.Product()
                {
                    Name = productSave.ProductName,
                    Description = "boş",
                    State = eCommerceContext.States.Single(a => a.Id == (int)Enums.State.Active),
                    Category = ???,
                    CreateDate = DateTime.UtcNow,
                    
                });
            }
                //var categorySave = new DTO.CategorySaveDto()
                //{
                //    ProductName = json
                //};
                return View();
        }
    }
}