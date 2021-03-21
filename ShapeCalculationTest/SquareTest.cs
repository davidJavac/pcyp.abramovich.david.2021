using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeCalculation;
using System;

namespace ShapeCalculationTest
{
    [TestClass]
    public class SquareTest
    {
        
        [TestMethod]
        public void when_side_is_2_then_area_should_be_4()
        {

            double expectedArea = 4.0;

            Square square = new Square(2);
            square.calculateArea();
            double area = square.getArea();

            Assert.AreEqual(expectedArea, area);
        }

        [TestMethod]
        public void when_side_is_2_then_perimeter_should_be_8()
        {

            double expectedPerimeter = 8.0;

            Square square = new Square(2);
            square.calculatePerimeter();
            double perimeter = square.getPerimeter();

            Assert.AreEqual(expectedPerimeter, perimeter);
        }
    }
}
