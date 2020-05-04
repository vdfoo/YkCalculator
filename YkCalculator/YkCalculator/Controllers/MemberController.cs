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
    public class MemberController : ControllerBase
    {
        // GET: api/Member/5
        [HttpGet("Validate/{memberId}")]
        public bool Validate(int memberId)
        {
            Member member = new Member();
            return member.Valdiate(memberId);
        }

        // POST: api/Member
        [HttpPost]
        public string Post([FromBody] Order order)
        {
            int orderId = order.Id;
            Member member = new Member();
            int memberId = member.CreateNewMember(orderId);
            if(memberId == 0)
            {
                return "Failed. Ensure you have valid OrderId";
            }
            else
            {
                return $"{memberId}";
            }
        }
    }
}
