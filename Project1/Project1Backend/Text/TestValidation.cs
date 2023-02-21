/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using NUnit.Framework;
//using static Microsoft.EntityFrameworkCore;

namespace Test
{
    [TestFixture]
    public class TestValidation
    {
        TValidation val = new TValidation();
        public void Setup()
        {
        }
        [Test]
        [TestCase("raghu@gmail.com", true)]
        [TestCase("ajay@gcom", false)]
        public void TestEmail(string Email, bool ExpectedValue)
        {
            var email = val.IsValidEmail(Email);

            Assert.AreEqual(email, ExpectedValue);
        }
        [Test]
        [TestCase("Raghu@123", true)]
        [TestCase("sid", false)]
        public void TestPassword(string Password, bool ExpectedValue)
        {
            var password = val.IsValidPassword(Password);
            Assert.AreEqual(password, ExpectedValue);
        }
        [Test]
        [TestCase("www.google.com", true)]
        [TestCase("google", false)]
        public void TestWebsite(string Website, bool ExpectedValue)
        {
            var website = val.IsValidWebsite(Website);
            Assert.AreEqual(website, ExpectedValue);
        }
        [Test]
        [TestCase("male", true)]
        [TestCase("mk", false)]
        [TestCase("female", true)]
        public void TestGender(string Gender, bool ExpectedValue)
        {
            var gender = val.IsValidGender(Gender);
            Assert.AreEqual(gender, ExpectedValue);
        }
        [Test]
        [TestCase("Dotnet", true)]
        [TestCase("Js", false)]
        [TestCase("Java", true)]
        public void TestSkill(string Skill, bool ExpectedValue)
        {
            var skill = val.IsValidSkillName(Skill);
            Assert.AreEqual(skill, ExpectedValue);
        }
    }
}*/
