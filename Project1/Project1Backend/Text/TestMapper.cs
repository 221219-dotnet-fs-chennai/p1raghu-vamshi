/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using NUnit.Framework;
using DD = EntityApi.Entities;
using Modules;

namespace Text
{
    [TestFixture]
    public class TestMapper
    {
        [Test]
        public void TestMap()
        {
            DD.UserDetail userDetail = new DD.UserDetail();
            var modelDD = Mapper.Map(userDetail);
            Assert.AreEqual(modelDD.GetType(), typeof(Modules.UserDetails));
        }
        [Test]
        public void TestEducation()
        {
            DD.Education education = new DD.Education();
            var EduDD = Mapper.Map(education);
            Assert.AreEqual(EduDD.GetType(), typeof(Modules.Education));
        }
        [Test]
        public void TestCompany()
        {
            DD.Company company = new DD.Company();
            var ComDD = Mapper.Map(company);
            Assert.AreEqual(ComDD.GetType(), typeof(Modules.Company));
        }
        [Test]
        public void TestAddress()
        {
            DD.Address address = new DD.Address();
            var EduDD = Mapper.Map(address);
            Assert.AreEqual(EduDD.GetType(), typeof(Modules.Address));
        }
        [Test]
        public void TestSkills()
        {
            DD.Skill skill = new DD.Skill();
            var EduDD = Mapper.Map(skill);
            Assert.AreEqual(EduDD.GetType(), typeof(Modules.Skills));
        }
    }
}
*/