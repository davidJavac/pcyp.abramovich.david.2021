using ShapeCalculation.adapter.dto;
using ShapeCalculation.adapter.exception;
using System;
using System.Collections.Generic;
using System.Text;
using ShapeCalculation.util;

namespace ShapeCalculation.adapter.validation.implementation
{
    public class ValidateShapeNameExists : ValidateInput<InputDto>
    {
        public void execute(InputDto input)
        {
            String shapeName = input.ShapeName;

            if ((!shapeName.Equals(ApplicationConstants.ShapeName.RECTANGLE,
                StringComparison.InvariantCultureIgnoreCase) &&
                    !shapeName.Equals(ApplicationConstants.ShapeName.TRIANGLE,
                    StringComparison.InvariantCultureIgnoreCase) &&
                    !shapeName.Equals(ApplicationConstants.ShapeName.SQUARE,
                    StringComparison.InvariantCultureIgnoreCase)) 
               )
            {

                throw new InvalidShapeNameException();
            }
        }
    }
}
