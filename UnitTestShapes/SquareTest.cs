using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var square = new Square();
            square.Top = 10;
            square.Right = 10;
            square.Bottom = 10;
            square.Left = 10;
            Assert.AreEqual(square.Area(), 100);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var square = new Square(10);
            Assert.AreEqual(square.Area(), 100);
        }
    }
}
