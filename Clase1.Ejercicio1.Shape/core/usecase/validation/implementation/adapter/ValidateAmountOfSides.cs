using Clase1Ejercicio1Shape.adapter.exception;
using Clase1Ejercicio1Shape.adapter.validation;
using Clase1Ejercicio1Shape.usecase.dto;
using Clase1Ejercicio1Shape.util;
using System;


namespace Clase1Ejercicio1Shape.usecase.validation.implementation
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
