using ShapeCalculation.adapter.dto;
using ShapeCalculation.adapter.exception;
using System;
using System.Collections.Generic;
using System.Text;
using ShapeCalculation.util;

namespace ShapeCalculation.adapter.validation.implementation
{
    class ValidateOperationNameExists : ValidateInput
    {
        public void execute(InputDto input)
        {
            String operationName = input.Operation;

            if (!operationName.Equals(ApplicationConstants.Operation.AREA,
                StringComparison.InvariantCultureIgnoreCase) &&
                    !operationName.Equals(ApplicationConstants.Operation.PERIMETER,
                    StringComparison.InvariantCultureIgnoreCase) 
               )
            {

                throw new InvalidOperationNameException();
            }
        }
    }
}
