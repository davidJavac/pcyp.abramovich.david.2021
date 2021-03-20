using ShapeCalculation.adapter.dto;
using ShapeCalculation.adapter.exception;
using System;
using System.Collections.Generic;
using System.Text;
using ShapeCalculation.util;

namespace ShapeCalculation.adapter.validation.implementation
{
    class ValidateSidesSeparatedByComma : ValidateInput
    {
        public void execute(InputDto input)
        {
            String shapeName = input.ShapeName;

            if (!shapeName.Equals(ApplicationConstants.ShapeName.SQUARE) &&
                !input.Values.Contains(",")
               )
            {

                throw new InvalidSidesDefinitionException();
            }
        }
    }
}
