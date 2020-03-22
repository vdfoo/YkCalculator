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
    public class LocationController : ControllerBase
    {
        // GET: api/Location
        [HttpGet]
        public Location Get()
        {
            Location location = new Location();
            location.TingkatBawah.Add("Tingkat Bawah 1");
            location.TingkatBawah.Add("Tingkat Bawah 2");
            location.TingkatBawah.Add("Tingkat Bawah 3");

            location.Tempat.Add("Ruang Tamu 1");
            location.Tempat.Add("Ruang Tamu 2");
            location.Tempat.Add("Ruang Tamu 3");
            location.Tempat.Add("Ruang Tamu 4");
            location.Tempat.Add("Ruang Tamu 5");
            location.Tempat.Add("Crown Ruang Tamu");
            location.Tempat.Add("Crown Dapur");
            location.Tempat.Add("Bilik Master");
            location.Tempat.Add("Bilik 1");
            location.Tempat.Add("Bilik 2");
            location.Tempat.Add("Bilik 3");
            location.Tempat.Add("Bilik 4");
            location.Tempat.Add("Bilik 5");
            location.Tempat.Add("Bilik 6");
            location.Tempat.Add("Bilik 7");
            location.Tempat.Add("Bilik 8");
            location.Tempat.Add("Dapur Bidai");
            location.Tempat.Add("Tangga");

            location.Sliding.Add("Sliding 1");
            location.Sliding.Add("Sliding 2");
            location.Sliding.Add("Sliding 3");
            location.Sliding.Add("Sliding 4");
            location.Sliding.Add("Sliding 5");

            location.Tingkap.Add("1 Panel");
            location.Tingkap.Add("1 Panel (L)");
            location.Tingkap.Add("2 Panel");
            location.Tingkap.Add("3 Panel");
            location.Tingkap.Add("4 Panel");

            return location;
        }
    }
}
