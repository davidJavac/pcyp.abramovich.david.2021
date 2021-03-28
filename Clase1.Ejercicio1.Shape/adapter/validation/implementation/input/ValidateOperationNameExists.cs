using Clase1Ejercicio1Shape.adapter.dto;
using Clase1Ejercicio1Shape.adapter.exception;
using Clase1Ejercicio1Shape.util;
using System;


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
