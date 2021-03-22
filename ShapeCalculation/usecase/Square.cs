using ShapeCalculation.config;
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
            invokeValidations();
            this.area = side * side;
        }

        public override void calculatePerimeter()
        {
            invokeValidations();
            this.perimeter = side * 4;
        }

        protected override void invokeValidations()
        {
            ModuleConfig.getCommonValidateValues().ForEach(val => val.execute(side));
        }

        public void setSide(double side) {
            this.side = side;
        }
    }
}
