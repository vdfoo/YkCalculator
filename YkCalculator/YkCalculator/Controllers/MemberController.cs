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
        // GET: api/Member/1001
        [HttpGet("Read/{memberId}")]
        public Member Read(int memberId)
        {
            MemberManager member = new MemberManager();
            return member.Read(memberId);
        }

        // GET: api/Member/Search
        [HttpGet("Search")]
        public List<Member> Read(string text)
        {
            MemberManager member = new MemberManager();
            return member.Search(text);
        }

        // POST: api/Member
        [HttpPost]
        public string Post([FromBody] Member member)
        {
            MemberManager memberManager = new MemberManager();
            int memberId = memberManager.CreateNewMember(member);
            if(memberId == 0)
            {
                return "Failed. Member not created";
            }
            else
            {
                return $"{memberId}";
            }
        }

        // POST: api/Member
        [HttpPut("Update")]
        public string Update([FromBody] Member member)
        {
            MemberManager memberManager = new MemberManager();
            int row = memberManager.Update(member);
            if (row == 0)
            {
                return "Failed. Member not updated";
            }
            else
            {
                return $"{row}";
            }
        }

        [HttpDelete("Delete/{memberId}")]
        public string Delete(int memberId)
        {
            MemberManager memberManager = new MemberManager();
            int row = memberManager.Delete(memberId);
            if (row == 0)
            {
                return "Failed. Member not deleted";
            }
            else
            {
                return $"{row}";
            }
        }
    }
}
