using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication;

namespace DemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Demo tp = new Demo();
            Assert.AreEqual(tp.Name, "Welcome from tapender");
        }
    }
}
