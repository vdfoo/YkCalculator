using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YkCalculator.Formula;
using YkCalculator.Model;

namespace YkCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class F1_1Controller : ControllerBase
    {
        [HttpGet]
        public F1_1_Result Get(F1_1_Input input)
        {
            F1_1 formula = new F1_1();
            F1_1_Result result = formula.Calculate(input);
            return result;
        }

        // GET: api/F1_1
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/F1_1/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/F1_1
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/F1_1/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
