using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.adapter
{
    class FactoryShape : Factory
    {
        public Shape create(String shape, List<Double> values) {

            switch (shape) {

                case "square" : return new Square(values[0]);
                default: throw new Exception();
            }
        }
    }
}
