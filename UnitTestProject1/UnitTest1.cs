using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var math = new GitUnitTestDemo.Math(5, 2);
            var math2 = new GitUnitTestDemo.Math(1234, 2);

            Assert.AreEqual(7, math.Add());
        }
    }
}
