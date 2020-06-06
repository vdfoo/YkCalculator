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

        //[HttpGet("ByUserId/{id}/Offset/{offset}")]
        //public List<Order> GetOrdersByUserId(string id, int offset)
        //{
        //    OrderDal dal = new OrderDal();
        //    return dal.ReadAll(offset, id);
        //}

        [HttpGet("ByConditions")]
        public List<Order> GetOrdersByConditions(string username, DateTime dateFrom, DateTime dateTo, 
            int orderIdFrom, int orderIdTo, int orderId, int offset)
        {
            SearchOrderCondition conditions = new SearchOrderCondition()
            {
                Username = username,
                OrderIdFrom = orderIdFrom,
                OrderIdTo = orderIdTo,
                Offset = offset,
                OrderId = orderId,
            };

            DateTime systemDefault = new DateTime();
            if(dateFrom != systemDefault)
            {
                conditions.DateFrom = dateFrom;
            }

            if (dateTo != systemDefault)
            {
                conditions.DateTo = dateTo;
            }

            OrderDal dal = new OrderDal();
            return dal.ReadAllByCondition(conditions);
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
