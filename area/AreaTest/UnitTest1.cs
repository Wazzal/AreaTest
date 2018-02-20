using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;
using area;

namespace AreaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircleArea()
        {
            IFigure circle = new Circle(3);

            Assert.AreEqual(28.26, circle.GetArea(), 0.01);
        }

        [TestMethod]
        public void TestRightTriangleArea()
        {
            IFigure triangle = new RightTriangle(4, 6);

            Assert.AreEqual(12, triangle.GetArea(), 0.01);
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            IFigure triangle = new Triangle(4, 6, 5);

            Assert.AreEqual(9.92, triangle.GetArea(), 0.01);
        }
    }
}
