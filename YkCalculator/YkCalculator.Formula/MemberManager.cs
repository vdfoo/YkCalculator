using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using YkCalculator.DAL;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class MemberManager
    {
        public int CreateNewMember(Member member)
        {
            MemberDal memberDal = new MemberDal();
            return memberDal.Insert(member);
        }

        public int Update(Member member)
        {
            MemberDal memberDal = new MemberDal();
            return memberDal.Update(member);
        }

        public int Delete(int memberId)
        {
            MemberDal memberDal = new MemberDal();
            return memberDal.Delete(memberId);
        }

        public List<Member> Search(string searchText)
        {
            List<Member> members = new List<Member>();
            MemberDal memberDal = new MemberDal();
            members = memberDal.Search(searchText);
            return members;
        }

        public Member Read(int memberId)
        {
            MemberDal memberDal = new MemberDal();
            return memberDal.Read(memberId);
        }
    }
}
