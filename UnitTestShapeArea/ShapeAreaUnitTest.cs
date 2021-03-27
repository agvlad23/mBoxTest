using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace UnitTestShapeArea
{
    [TestClass]
    public class ShapeAreaUnitTest
    {
        [TestMethod]
        public void testCircleArea()
        {
            double r = 24;
            var circle = new ShapeArea.Circle(r);
            var area = circle.Area();
            Assert.AreEqual(1809.557, area, 0.001);
        }

        [TestMethod]
        public void testTriangleArea()
        {
            double side1 = 12;
            double side2 = 34;
            double side3 = 25;
            var triangle = new ShapeArea.Triangle(side1, side2, side3);
            var area = triangle.Area();
            Assert.AreEqual(114.62738, area, 0.0001);

            triangle.side3 = 225;
            area = triangle.Area();
            Assert.AreEqual(0, area, 0.0001);
        }

        [TestMethod]
        public void testTriangleIsRight()
        {
            double side1 = 12;
            double side2 = 34;
            double side3 = 25;
            var triangle = new ShapeArea.Triangle(side1, side2, side3);
            var isRight = triangle.IsRight();
            Assert.AreEqual(false, isRight);

            triangle.side1 = 8;
            triangle.side2 = 6;
            triangle.side3 = 10;
            isRight = triangle.IsRight();
            Assert.AreEqual(true, isRight);
        }

        [TestMethod]
        public void testAnyArea()
        {
            Assert.AreEqual(1809.557, ShapeArea.Area.AnyShape(24), 0.001);
            Assert.AreEqual(114.62738, ShapeArea.Area.AnyShape(12, 34, 25), 0.0001);
            Point[] points = new[]
            {
                new Point(3, 4),
                new Point(5, 11),
                new Point(12, 8),
                new Point(9, 5),
                new Point(5, 6)
            };

            Assert.AreEqual(30, ShapeArea.Area.AnyShape(points), 1);

            points = new[]
{
                new Point(5, 6),
                new Point(9, 5),
                new Point(12, 8),
                new Point(5, 11),
                new Point(3, 4)
            };

            Assert.AreEqual(30, ShapeArea.Area.AnyShape(points), 1);

            points = new[]
            {
                new Point(44, 58),
                new Point(22, 62),
                new Point(3, 12)
            };

            Assert.AreEqual(588, ShapeArea.Area.AnyShape(points), 1);
            Assert.AreEqual(588, ShapeArea.Area.AnyShape(22.361, 61.619, 53.488), 0.01);
        }

    }
}
