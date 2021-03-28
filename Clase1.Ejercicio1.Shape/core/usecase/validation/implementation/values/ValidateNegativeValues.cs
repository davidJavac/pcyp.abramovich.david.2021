using Clase1Ejercicio1Shape.core.usecase.validation;
using Clase1Ejercicio1Shape.usecase.exception;
using System;
using System.Collections.Generic;

namespace Clase1Ejercicio1Shape.usecase.validation.implementation
{
    class ValidateNegativeValues : ValidateValues<Double>
    {
        public void execute(params Double[] values)
        {
            List<Double> listValues = new List<Double>(values);

            listValues.ForEach(value =>
            {
                if (value <= 0) throw new NegativeValueException();
            });

        }
    }
}
