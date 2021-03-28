using Clase1Ejercicio1Shape.adapter.dto;
using Clase1Ejercicio1Shape.adapter.exception;
using Clase1Ejercicio1Shape.util;
using System;


namespace Clase1Ejercicio1Shape.adapter.validation.implementation
{
    public class ValidateSidesSeparatedByComma : ValidateInput<InputDto>
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
