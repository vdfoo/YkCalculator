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
    public class OutputLabelController : ControllerBase
    {
        // GET: api/OutputLabel
        [HttpGet]
        public OutputLabelCollection Get()
        {
            return new OutputLabelCollection();
        }

        [HttpGet("HiddenLabelCollection")]
        public HiddenLabelCollection HiddenLabelCollection()
        {
            return new HiddenLabelCollection();
        }

        [HttpGet("CustomerSummaryLabelCollection")]
        public CustomerSummaryLabelCollection CustomerSummaryLabelCollection()
        {
            return new CustomerSummaryLabelCollection();
        }

    }
}
