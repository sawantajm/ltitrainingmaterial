using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using prjEmployee;
namespace Testcase
{
    internal class Test
    {
        List<EmployeeDetails> li;
        Logic logic = new Logic();
        [Test]

        public void CheckDetails()
        {
            li = logic.AllUser();
            foreach (var item in li)
            {
                Assert.IsNotNull(item.id);
                Assert.IsNotNull(item.name);
                Assert.IsNotNull(item.Gender);
                Assert.IsNotNull(item.salary);
            }
        }
        [Test]

        public void TestLogin()
        {
            string a = logic.Login("kani", "123");
            string b = logic.Login("", "");
            string c = logic.Login("Admin", "Admin");

            Assert.AreEqual("userid or Password cant be Null!!", b);
            Assert.AreEqual("Incorrect username or password", a);
            Assert.AreEqual("Welcome Admin", c);

        }
    }
}
