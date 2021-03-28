﻿using Clase1Ejercicio1Shape.util;

namespace Clase1Ejercicio1Shape.usecase
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
