using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2048game;
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
