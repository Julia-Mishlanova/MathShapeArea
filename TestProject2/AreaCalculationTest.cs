using MathShapeArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject2
{
    [TestClass]
    public class AreaCalculationTest
    {
        [TestMethod]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle(6);
            var area = circle.CalculateArea();

            Assert.AreEqual(113.09733552923255, area);
        }

        [TestMethod]
        public void ResizeRectangleToSquare()
        {
            Rectangle rectangle = new Rectangle(3.0, 4.0);
            Square resizedSquare = (Square)new Square(2.5).Resize(3.0, 3.0);

            Assert.AreEqual(3.0, resizedSquare.Side);
        }

        [TestMethod]
        public void ResizeSquareToRectangle()
        {
            Square square = new Square(2.5);
            Rectangle resizedRectangle = square.Resize(3.0, 4.0);

            Assert.AreEqual(3.0, resizedRectangle.Width);
            Assert.AreEqual(4.0, resizedRectangle.Height);
        }

        [TestMethod]
        public void SquareAreaCalculation()
        {
            Square square = new Square(2.5);
            double expectedArea = 2.5 * 2.5;

            double actualArea = square.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [TestMethod]
        public void RectangleAreaCalculation()
        {
            Rectangle rectangle = new Rectangle(3.0, 4.0);
            double expectedArea = 3.0 * 4.0;

            double actualArea = rectangle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }
    }
}
