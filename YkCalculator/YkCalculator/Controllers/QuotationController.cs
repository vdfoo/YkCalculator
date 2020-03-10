using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YkCalculator.DAL;
using YkCalculator.Model;

namespace YkCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotationController : ControllerBase
    {
        // PUT: api/Quotation/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] QuotationImage quotationImage)
        {
            Quotation quotation = new Quotation();
            quotation.Update(id, quotationImage.Image);
        }
    }
}
