using ShapeCalculation.adapter.dto;
using ShapeCalculation.adapter.exception;
using ShapeCalculation.usecase;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.config
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
