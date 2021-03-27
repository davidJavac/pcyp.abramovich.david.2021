using Clase1Ejercicio2Vial.config;
using Clase1Ejercicio2Vial.util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio2Vial.usecase
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
            this.area = sideA * sideB;
        }

        public override void calculatePerimeter()
        {
            this.perimeter = 2 * (sideA + sideB);
        }

        public override string getName()
        {
            return ApplicationConstants.ShapeName.RECTANGLE;
        }

        protected override void invokeValidations()
        {
        }
    }
}
