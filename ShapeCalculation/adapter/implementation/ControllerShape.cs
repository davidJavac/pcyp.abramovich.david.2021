using System;
using System.Collections.Generic;
using System.Text;
using ShapeCalculation.adapter.dto;
using ShapeCalculation.util;
using ShapeCalculation.adapter.exception;

namespace ShapeCalculation.adapter
{
    class ControllerShape : Input
    {
        private List<Double> values;

        public ControllerShape() {
            this.values = new List<Double>();
        }

        public double getCalculatedValue(InputDto input)
        {
            convertedSidesToDouble(input.Values);

            validateAmountOfSides(input);

            Factory factory = new FactoryShape();

            Shape shape = factory.create(input.ShapeName, values);

            if (isAreaOperation(input.Operation))
            {
                shape.calculateArea();
                return shape.getArea();
            }
            else if (isPerimeterOperation(input.Operation))
            {
                shape.calculatePerimeter();
                return shape.getPerimeter();
            }
            else {
                throw new InvalidOperationNameException();
            }
        }

        private bool isAreaOperation(String operation) {
            return (operation.Equals(ApplicationConstants.Operation.AREA, 
                StringComparison.InvariantCultureIgnoreCase));
        }

        private bool isPerimeterOperation(String operation)
        {
            return (operation.Equals(ApplicationConstants.Operation.PERIMETER, 
                StringComparison.InvariantCultureIgnoreCase));
        }

        private void convertedSidesToDouble(String values) {

            String[] splitedValues = values.Split(",");

            foreach(String s in splitedValues) {
                this.values.Add(Convert.ToDouble(s));
            }
            
        }

        private void validateAmountOfSides(InputDto input) {

            String shapeName = input.ShapeName;

            if (shapeName.Equals(ApplicationConstants.ShapeName.SQUARE,
                StringComparison.InvariantCultureIgnoreCase) && this.values.Count != 1 ||
                    shapeName.Equals(ApplicationConstants.ShapeName.TRIANGLE,
                    StringComparison.InvariantCultureIgnoreCase) && this.values.Count != 3 ||
                        shapeName.Equals(ApplicationConstants.ShapeName.TRIANGLE,
                        StringComparison.InvariantCultureIgnoreCase) && this.values.Count != 2
                ) {

                throw new InvalidAmountOfSidesException(shapeName);
            }

        }
    }
}
