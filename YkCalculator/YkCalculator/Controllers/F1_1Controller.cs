using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YkCalculator.Logic;
using YkCalculator.Model;

namespace YkCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class F1_1Controller : ControllerBase
    {
        [HttpGet]
        public Output Get(Input input)
        {
            F1_1 formula = new F1_1();
            Output result = formula.Calculate(input);
            return result;
        }
    }
}
