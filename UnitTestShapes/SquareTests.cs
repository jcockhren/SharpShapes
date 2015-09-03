using System;
using Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestShapes
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void SquareAreaTest()
        {
            Square s = new Square(5);
            Assert.AreEqual(25, s.Area());
        }
    }
}
