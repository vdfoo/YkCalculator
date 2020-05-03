using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using YkCalculator.DAL;

namespace YkCalculator.Logic
{
    public class Member
    {
        public int CreateNewMember(int orderId)
        {
            OrderDal orderDal = new OrderDal();
            Thread.Sleep(1000);
            var order = orderDal.Read(orderId);
            int memberId = 0;
            if (order.Id != 0)
            {
                MemberDal memberDal = new MemberDal();
                memberId = memberDal.Insert();
                int memberOrderId = memberDal.InsertMemberOrder(orderId, memberId);
            }

            return memberId;
        }

        public bool Valdiate(int memberId)
        {
            MemberDal memberDal = new MemberDal();
            int resultMemberId = memberDal.Read(memberId);
            if(resultMemberId == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
