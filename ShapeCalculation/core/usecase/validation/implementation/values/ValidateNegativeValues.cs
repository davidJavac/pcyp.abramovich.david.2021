using Clase1Ejercicio2Vial.adapter.validation;
using Clase1Ejercicio2Vial.core.usecase.validation;
using Clase1Ejercicio2Vial.usecase.dto;
using Clase1Ejercicio2Vial.usecase.exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio2Vial.usecase.validation.implementation
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
