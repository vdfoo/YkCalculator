using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.DAL;
using System.Text.Json;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class MemberManagerTests
    {
        [TestMethod()]
        public void CreateNewMemberTest()
        {
            MemberDetail detail = new MemberDetail();
            detail.Email = "a@a.com";
            detail.ExternalReference = "1234-1234-1234-1234";
            detail.Name = "John Doe";
            detail.Phone = "0126461560";

            Member member = new Member();
            member.CreatedBy = "kelvin";
            member.Detail = detail;

            string memberJson = JsonSerializer.Serialize(member);

            //MemberDal dal = new MemberDal();
            //int memberId = dal.Insert(member);
            //Assert.AreNotEqual(0, memberId);
        }
    }
}