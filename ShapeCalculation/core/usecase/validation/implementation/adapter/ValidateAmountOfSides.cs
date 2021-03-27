using Clase1Ejercicio2Vial.usecase.dto;
using Clase1Ejercicio2Vial.adapter.exception;
using System;
using System.Collections.Generic;
using Clase1Ejercicio2Vial.util;
using Clase1Ejercicio2Vial.adapter.validation;

namespace Clase1Ejercicio2Vial.usecase.validation.implementation
{
    class ValidateAmountOfSides : ValidateInput<Tuple<String, InputAdapterDto>>
    {
        public void execute(Tuple<String, InputAdapterDto> tuple)
        {
            String shapeName = tuple.Item1;
            InputAdapterDto input = tuple.Item2;

            if ((shapeName.Equals(ApplicationConstants.ShapeName.SQUARE,
                StringComparison.InvariantCultureIgnoreCase) && input.Values.Count != 1) ||
                    (shapeName.Equals(ApplicationConstants.ShapeName.TRIANGLE,
                    StringComparison.InvariantCultureIgnoreCase) && input.Values.Count != 3) ||
                        (shapeName.Equals(ApplicationConstants.ShapeName.RECTANGLE,
                        StringComparison.InvariantCultureIgnoreCase) && input.Values.Count != 2)
                )
            {

                throw new InvalidAmountOfSidesException(shapeName);
            }
            
        }
    }
}
