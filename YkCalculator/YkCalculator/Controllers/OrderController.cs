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
    public class OrderController : ControllerBase
    {
        // GET: api/Order/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            OrderDal dal = new OrderDal();
            return dal.Read(id);
        }

        // POST: api/Order
        [HttpPost]
        public int Post([FromBody] Order order)
        {
            OrderDal dal = new OrderDal();
            return dal.Insert(order);
        }

        // PUT: api/Order
        [HttpPut]
        public void Put([FromBody] Order order)
        {
            OrderDal dal = new OrderDal();
            dal.Update(order);
        }
    }
}
