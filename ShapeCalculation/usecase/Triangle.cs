using ShapeCalculation.config;
using ShapeCalculation.usecase.validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation
{
    public class Triangle : Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC) {

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public override void calculateArea()
        {
            invokeValidations();
            double s = (sideA + sideB + sideC) / 2;
            this.area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public override void calculatePerimeter()
        {
            invokeValidations();
            this.perimeter = sideA + sideB + sideC;   
        }

        protected override void invokeValidations()
        {
            ModuleConfig.getValidateTriangleValues().ForEach(val => val.execute(sideA, sideB, sideC));
        }
    }
}
