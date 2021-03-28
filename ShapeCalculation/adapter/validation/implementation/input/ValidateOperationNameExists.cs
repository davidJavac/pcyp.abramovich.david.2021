using Clase1Ejercicio2Vial.adapter.dto;
using Clase1Ejercicio2Vial.adapter.exception;
using System;
using System.Collections.Generic;
using System.Text;
using Clase1Ejercicio2Vial.util;

namespace Clase1Ejercicio1Shape.adapter.validation.implementation
{
    public class ValidateOperationNameExists : ValidateInput<InputDto>
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
