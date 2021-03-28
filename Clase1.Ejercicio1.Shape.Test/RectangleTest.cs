using Clase1Ejercicio1Shape.usecase;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ShapeCalculationTest
{
    [TestClass]
    public class RectangleTest
    {
        
        [TestMethod]
        public void when_sides_are_2_and_4_then_area_should_be_8()
        {

            double expectedArea = 8.0;

            Rectangle rectangle = new Rectangle(2, 4);
            rectangle.calculateArea();
            double area = rectangle.getArea();

            Assert.AreEqual(expectedArea, area);
        }

        [TestMethod]
        public void when_sides_are_2_and_4_then_perimeter_should_be_12()
        {

            double expectedPerimeter = 12.0;

            Rectangle rectangle = new Rectangle(2, 4);
            rectangle.calculatePerimeter();
            double perimeter = rectangle.getPerimeter();

            Assert.AreEqual(expectedPerimeter, perimeter);
        }
        
    }
}
