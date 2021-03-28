using Clase1Ejercicio1Shape.core.usecase.validation;
using Clase1Ejercicio1Shape.usecase.exception;
using System;


namespace Clase1Ejercicio1Shape.usecase.validation.implementation
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
