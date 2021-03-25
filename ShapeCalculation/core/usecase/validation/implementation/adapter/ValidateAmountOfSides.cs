using ShapeCalculation.usecase.dto;
using ShapeCalculation.adapter.exception;
using System;
using System.Collections.Generic;
using ShapeCalculation.util;
using ShapeCalculation.adapter.validation;

namespace ShapeCalculation.usecase.validation.implementation
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
