using ShapeCalculation.usecase.exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.usecase.validation.implementation
{
    class ValidateNegativeValues : ValidateValues<Double>
    {
        public void execute(params Double [] values)
        {
            List<Double> listValues = new List<Double>(values);

            listValues.ForEach(value =>
            {
                if (value <= 0) throw new NegativeValueException();
            });

        }
    }
}
