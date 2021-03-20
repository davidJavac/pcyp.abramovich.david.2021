using ShapeCalculation.adapter.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.adapter
{
    class FactoryShape : Factory
    {
        public Shape create(InputAdapterDto inputAdapterDto) {
            String shape = inputAdapterDto.ShapeName;
            List<Double> values = inputAdapterDto.Values;
            switch (shape) {

                case "square" : return new Square(values[0]);
                case "triangle": return new Triangle(values[0], values[1], values[2]);
                default: throw new Exception();
            }
        }
    }
}
