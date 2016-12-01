using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerialOperations;

namespace SerialActivator.UnitTest
{
    [TestClass]
    public class MainTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Operations SOperations = new Operations();
            String Key = "awdawd";
            Assert.IsFalse(SOperations.VerifyCode(Key));
        }
    }
}
