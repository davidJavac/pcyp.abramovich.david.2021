using ShapeCalculation.usecase.dto;
using ShapeCalculation.adapter.exception;
using System;
using System.Collections.Generic;
using System.Text;
using ShapeCalculation.util;

namespace ShapeCalculation.usecase.validation.implementation
{
    class ValidateAmountOfSides : ValidateAdapter
    {
        public void execute(InputAdapterDto inputAdapterDto)
        {
            String shapeName = inputAdapterDto.Shape.getName();
            List<Double> values = inputAdapterDto.Values;

            if ((shapeName.Equals(ApplicationConstants.ShapeName.SQUARE,
                StringComparison.InvariantCultureIgnoreCase) && values.Count != 1) ||
                    (shapeName.Equals(ApplicationConstants.ShapeName.TRIANGLE,
                    StringComparison.InvariantCultureIgnoreCase) && values.Count != 3) ||
                        (shapeName.Equals(ApplicationConstants.ShapeName.RECTANGLE,
                        StringComparison.InvariantCultureIgnoreCase) && values.Count != 2)
                )
            {

                throw new InvalidAmountOfSidesException(shapeName);
            }
            
        }
    }
}
