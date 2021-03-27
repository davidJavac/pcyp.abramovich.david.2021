using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clase1Ejercicio2Vial;
using Clase1Ejercicio2Vial.usecase;
using Clase1Ejercicio2Vial.usecase.exception;
using System;

namespace ShapeCalculationTest
{
    [TestClass]
    public class TriangleTest
    {

        [TestMethod]
        public void when_sides_are_2_and_4_and_5_then_area_should_be_3_8()
        {

            double expectedArea = 3.8;

            Triangle triangle = new Triangle(2, 4, 5);
            triangle.calculateArea();
            double area = triangle.getArea();

            Assert.AreEqual(expectedArea, Math.Round(area, 2));
        }

        [TestMethod]
        public void when_sides_are_2_and_4__and_5_then_perimeter_should_be_11()
        {

            double expectedPerimeter = 11.0;

            Triangle triangle = new Triangle(2, 4, 5);
            triangle.calculatePerimeter();
            double perimeter = triangle.getPerimeter();

            Assert.AreEqual(expectedPerimeter, perimeter);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSizeOfSideException))]
        public void when_calculate_area_and_one_of_the_sides_is_higer_or_equal_than_the_sum_of_the_remaining_two_then_it_should_throw_exception()
        {

            Triangle triangle = new Triangle(2, 4, 8);
            triangle.calculateArea();
            triangle.calculatePerimeter();
        }

    }
}
