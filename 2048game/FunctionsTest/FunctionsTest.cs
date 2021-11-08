using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FunctionsTest
{
    [TestClass]
    public class FunctionsTest
    {
        [TestMethod]
        public void functionsClassCreationTest()
        {
            Function function = new Function();
            Assert.IsNotNull(function);
        }
    }
}
