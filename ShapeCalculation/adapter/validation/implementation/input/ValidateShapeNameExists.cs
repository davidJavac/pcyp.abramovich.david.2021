using Clase1Ejercicio2Vial.adapter.dto;
using Clase1Ejercicio2Vial.adapter.exception;
using System;
using System.Collections.Generic;
using System.Text;
using Clase1Ejercicio2Vial.util;

namespace Clase1Ejercicio1Shape.adapter.validation.implementation
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
