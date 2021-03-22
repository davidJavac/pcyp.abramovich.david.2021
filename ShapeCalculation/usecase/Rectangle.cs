using ShapeCalculation.config;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.usecase
{
    public class Rectangle : Shape
    {
        private double sideA;
        private double sideB;

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public override void calculateArea()
        {
            invokeValidations();
            this.area = sideA * sideB;
        }

        public override void calculatePerimeter()
        {
            invokeValidations();
            this.perimeter = 2 * (sideA + sideB);
        }

        protected override void invokeValidations()
        {
            ModuleConfig.getCommonValidateValues().ForEach(val => val.execute(sideA, sideB));
        }
    }
}
