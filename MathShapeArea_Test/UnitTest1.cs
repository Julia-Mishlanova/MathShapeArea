using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathShapeArea;

namespace MathShapeArea_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Square square = new Square(2.5);

            // Изменяем его размер
            Rectangle resizedSquare = square.Resize(3.0, 4.0);

            // Создаем прямоугольник
            Rectangle rectangle = new Rectangle(3.0, 4.0);

            // Изменяем его размер
            Square resizedRectangle = new Square(2.5).Resize(3.0, 3.0);
        }
    }
}
