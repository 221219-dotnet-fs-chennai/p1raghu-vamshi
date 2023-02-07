using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using NUnit.Framework;
using DD = EntityApi.Entities;

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
    }
}
