using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YkCalculator.Model;

namespace YkCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IEnumerable<Product> Get()
        {
            Product p1 = new Product()
            {
                Name = "Short Name 1",
                ImagePath = "https://www.crismatec.com/python/cu/living-room-curtains-designs-excellent-on-intended-window-curtain_living-room-layout-and-decor-301x301.jpg",
                FormulaCode = "F1_1"
            };

            Product p2 = new Product()
            {
                Name = "Short Name 2",
                ImagePath = "https://www.crismatec.com/python/cu/living-room-curtains-designs-excellent-on-intended-window-curtain_living-room-layout-and-decor-301x301.jpg",
                FormulaCode = "F1_2"
            };

            Product p3 = new Product()
            {
                Name = "Short Name 3",
                ImagePath = "https://www.crismatec.com/python/cu/living-room-curtains-designs-excellent-on-intended-window-curtain_living-room-layout-and-decor-301x301.jpg",
                FormulaCode = "F3_1"
            };

            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            return products;
        }
    }
}