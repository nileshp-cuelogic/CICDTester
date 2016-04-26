using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Models;

namespace HelloWorldUnitTest
{
    [TestClass]
    public class AccountControllerTester
    {
        [TestMethod]
        public void CreateHelloWorldStringTest()
        {
            ClsTester obj = new ClsTester();
            Assert.AreEqual("Hello World", obj.CreateHelloWorldString());
               
        }
    }
}
