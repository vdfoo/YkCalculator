using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YkCalculator.DAL;
using YkCalculator.Logic;
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

        [HttpGet("All")]
        public List<Order> GetOrders()
        {
            OrderDal dal = new OrderDal();
            return dal.ReadAll();
        }

        [HttpGet("ByUserId/{id}")]
        public List<Order> GetOrdersByUserId(int id)
        {
            OrderDal dal = new OrderDal();
            return dal.ReadAll(id);
        }

        // POST: api/Order
        [HttpPost]
        public OrderResult Post([FromBody] Order order)
        {
            OrderManager manager = new OrderManager();
            return manager.PlaceOrder(order);
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
