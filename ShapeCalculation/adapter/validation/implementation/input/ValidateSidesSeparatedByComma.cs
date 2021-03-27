using Clase1Ejercicio2Vial.adapter.dto;
using Clase1Ejercicio2Vial.adapter.exception;
using System;
using System.Collections.Generic;
using System.Text;
using Clase1Ejercicio2Vial.util;

namespace Clase1Ejercicio2Vial.adapter.validation.implementation
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
