using Clase1Ejercicio1Shape.adapter.exception;
using Clase1Ejercicio1Shape.usecase;
using System;
using System.Collections.Generic;


namespace Clase1Ejercicio1Shape.config
{
    class FactoryShape : Factory
    {
        public Shape create(String shapeName, List<Double> values) {
               
            switch (shapeName) {

                case "square" : return new Square(values[0]);
                case "triangle": return new Triangle(values[0], values[1], values[2]);
                case "rectangle": return new Rectangle(values[0], values[1]);
                default: throw new InvalidShapeNameException();
            }
        }
    }
}
