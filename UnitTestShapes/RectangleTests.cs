using System;
using Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestShapes
{
    [TestClass]
    public class RectanlgeTests
    {
        [TestMethod]
        public void RectangleAreaTest()
        {
            Rectangle r = new Rectangle(4, 6);
            Assert.AreEqual(24, r.Area());
        }

        [TestMethod]
        public void RectanglePerimeterTest()
        {
            Rectangle r = new Rectangle(4, 6);
            Assert.AreEqual(20, r.Perimeter());
        }
    }
}
