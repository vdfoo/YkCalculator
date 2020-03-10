using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YkCalculator.DAL;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        // GET: api/HealthCheck
        [HttpGet]
        public string Get()
        {
            return "fantastic";
        }

        // GET: api/HealthCheck/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            // 1 - database stuff
            if(id == 1)
            {
                Quotation quotation = new Quotation();
                quotation.Read(1);

                Input input = new Input()
                {
                    HargaKainA = 15,
                    Tinggi = 120,
                    Lebar = 55,
                    Set = 3,
                    Tempat = "Ruang Tamu 2"
                };

                int i = quotation.Insert(input);

                List<string> image = new List<string>()
                {
                    "https://i.postimg.cc/G27TFN7F/F1-1.jpg",
                    "https://i.postimg.cc/zBc3bhvp/F1-2.jpg",
                    "https://i.postimg.cc/P53D0HL8/F3-1.jpg"
                };

                quotation.Update(i, image);
            }

            return ":)";
        }

    }
}
