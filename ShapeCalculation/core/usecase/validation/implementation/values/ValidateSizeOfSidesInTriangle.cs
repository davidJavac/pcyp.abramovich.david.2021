using Clase1Ejercicio2Vial.adapter.validation;
using Clase1Ejercicio2Vial.core.usecase.validation;
using Clase1Ejercicio2Vial.usecase.dto;
using Clase1Ejercicio2Vial.usecase.exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio2Vial.usecase.validation.implementation
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
