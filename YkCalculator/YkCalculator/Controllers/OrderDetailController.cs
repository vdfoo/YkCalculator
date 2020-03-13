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
    public class OrderDetailController : ControllerBase
    {
        // GET: api/OrderDetail/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            OrderDal dal = new OrderDal();
            Order order = dal.Read(id, true);
            return order;
        }
    }
}
