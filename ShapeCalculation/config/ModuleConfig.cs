using System;
using System.Collections.Generic;
using System.Text;
using Clase1Ejercicio2Vial.adapter;
using Clase1Ejercicio2Vial.adapter.dto;
using Clase1Ejercicio2Vial.adapter.validation;
using Clase1Ejercicio2Vial.adapter.validation.implementation;
using Clase1Ejercicio2Vial.core.usecase.validation;
using Clase1Ejercicio2Vial.usecase.dto;
using Clase1Ejercicio2Vial.usecase.validation;
using Clase1Ejercicio2Vial.usecase.validation.implementation;


namespace Clase1Ejercicio2Vial.config
{
    public class ModuleConfig
    {
        public static List<ValidateInput<InputDto>> getValidateInput() {
            List<ValidateInput<InputDto>> listValidateInput = new List<ValidateInput<InputDto>>();
            listValidateInput.Add(new ValidateShapeNameExists());
            listValidateInput.Add(new ValidateOperationNameExists());
            listValidateInput.Add(new ValidateSidesSeparatedByComma());
            return listValidateInput;
        }

        public static List<ValidateInput<Tuple<String, InputAdapterDto>>> getValidateInputAdapter()
        {
            List<ValidateInput<Tuple<String, InputAdapterDto>>> listValidateAdapter = new List<ValidateInput<Tuple<String, InputAdapterDto>>>();
            listValidateAdapter.Add(new ValidateAmountOfSides());
            return listValidateAdapter;
        }

        public static List<ValidateValues<Double>> getValidateTriangleValues()

        {
            List<ValidateValues<Double>> listValidateInputAdapter = new List<ValidateValues<Double>>();
            listValidateInputAdapter.Add(new ValidateSizeOfSidesInTriangle());
            return listValidateInputAdapter;
        }

        public static List<ValidateValues<Double>> getCommonValidateValues()

        {
            List<ValidateValues<Double>> listValidateValues = new List<ValidateValues<Double>>();
            listValidateValues.Add(new ValidateNegativeValues());
            return listValidateValues;
        }

        public static Shape createShape(String shapeName, List<Double> values) {

            Factory factory = new FactoryShape();

            return factory.create(shapeName, values);
        }
    }
}
