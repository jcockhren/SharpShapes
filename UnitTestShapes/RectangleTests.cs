using System;
using Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.Linq;

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

        [TestMethod]
        public void TestCorrectNumberofArguments()
        {
            var theClass = Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes().Where(shapeType => shapeType.Name == "Rectangle").First(); // This is a Collection. Get the First
            var theClassConstructor = theClass.GetConstructors().First();
            Assert.AreEqual(2,theClassConstructor.GetParameters().Length);
        }
    }
}
