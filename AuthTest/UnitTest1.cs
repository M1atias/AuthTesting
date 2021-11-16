using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AuthTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = AuthTesting.Program.Something();
            Assert.AreEqual("something", result);
        }

        [TestMethod]
        public void TestLoguinTrue()
        {
            bool result = AuthTesting.Program.Loguin("mmolina", "123456");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestLoguinFalse()
        {
            bool result = AuthTesting.Program.Loguin("manglada", "654321");
            Assert.AreEqual(false, result);
        }
    }
}
