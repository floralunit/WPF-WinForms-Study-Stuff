using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2048game;
using System;

namespace FunctionsTest
{
    [TestClass]
    public class FunctionsTest
    {
        [TestMethod]
        public void functionClassCreationTest()
        {
            Function function = new Function();
            Assert.IsNotNull(function);
        }
        [TestMethod]
        public void mergeTest ()
        {
            Function function = new Function();
            string [] arr = {2.ToString(), 4.ToString(), 16.ToString()};
            Assert.AreEqual(arr, function.Merge(arr));
        }
        [TestMethod]
        public void transposeTest()
        {
            Function function = new Function();
            string[][] doubleArr = new string [16][ ];
            Assert.AreNotEqual(doubleArr, function.Transpose(doubleArr));
        }
    }
}
