using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeCalculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculationTest
{
    [TestClass]
    class SquareTest
    {
        [TestInitialize]
        public void testInitialize()
        {

        }

        [TestMethod]
        public void when_side_is_2_then_area_should_be_4() {

            double expectedArea = 4.0;

            Square square = new Square(2);
            square.calculateArea();
            double area = square.getArea();

            Assert.AreEqual(expectedArea, area);
        }
    }
}
