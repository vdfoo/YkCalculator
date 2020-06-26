using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class Member
    {
        public int MemberId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public MemberDetail Detail { get; set; }
    }
}
