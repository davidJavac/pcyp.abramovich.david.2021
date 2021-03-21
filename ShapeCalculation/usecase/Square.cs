using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation
{
    public class Square : Shape
    {
        private double side;

        public Square(double side) {

            this.side = side;
        }

        public override void calculateArea()
        {
            this.area = side * side;
        }

        public override void calculatePerimeter()
        {
            this.perimeter = side * 4;
        }

        public void setSide(double side) {
            this.side = side;
        }
    }
}
