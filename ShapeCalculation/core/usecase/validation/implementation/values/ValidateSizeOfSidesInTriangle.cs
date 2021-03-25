using ShapeCalculation.adapter.validation;
using ShapeCalculation.core.usecase.validation;
using ShapeCalculation.usecase.dto;
using ShapeCalculation.usecase.exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.usecase.validation.implementation
{
    class ValidateSizeOfSidesInTriangle : ValidateValues<Double>
    {
        public void execute(params Double[] values)
        {
            double sideA = values[0];
            double sideB = values[1];
            double sideC = values[2];

            if (sideA >= (sideB + sideC) ||
                sideB >= (sideA + sideC) ||
                sideC >= (sideA + sideB)) { 
            
                throw new InvalidSizeOfSideException();
            }

        }
    }
}
