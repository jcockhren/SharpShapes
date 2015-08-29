using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void DefaultCanComputeArea()
        {
            var rectangle = new Rectangle();
            rectangle.Top = 5;
            rectangle.Right = 3;
            rectangle.Bottom = 5;
            rectangle.Left = 3;
            Assert.AreEqual(rectangle.Area(), 15);
        }
        [TestMethod]
        public void RectangleCanComputeArea()
        {
            var rectangle = new Rectangle(3, 5);
            Assert.AreEqual(rectangle.Area(), 15);
        }
    }
}