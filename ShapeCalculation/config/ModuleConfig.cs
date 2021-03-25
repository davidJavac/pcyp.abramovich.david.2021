using System;
using System.Collections.Generic;
using System.Text;
using ShapeCalculation.adapter;
using ShapeCalculation.adapter.dto;
using ShapeCalculation.adapter.validation;
using ShapeCalculation.adapter.validation.implementation;
using ShapeCalculation.core.usecase.validation;
using ShapeCalculation.usecase.dto;
using ShapeCalculation.usecase.validation;
using ShapeCalculation.usecase.validation.implementation;


namespace ShapeCalculation.config
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
