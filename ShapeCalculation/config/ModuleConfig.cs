using System;
using System.Collections.Generic;
using System.Text;
using ShapeCalculation.adapter.validation;
using ShapeCalculation.adapter.validation.implementation;
using ShapeCalculation.usecase.validation;
using ShapeCalculation.usecase.validation.implementation;


namespace ShapeCalculation.config
{
    class ModuleConfig
    {
        public static List<ValidateInput> getValidateInput() {
            List<ValidateInput> listValidateInput = new List<ValidateInput>();
            listValidateInput.Add(new ValidateShapeNameExists());
            listValidateInput.Add(new ValidateOperationNameExists());
            listValidateInput.Add(new ValidateSidesSeparatedByComma());
            return listValidateInput;
        }

        public static List<ValidateAdapter> getValidateAdapter()
        {
            List<ValidateAdapter> listValidateAdapter = new List<ValidateAdapter>();
            listValidateAdapter.Add(new ValidateAmountOfSides());
            return listValidateAdapter;
        }

        public static List<ValidateValues<Double>> getValidateTriangleValues()

        {
            List<ValidateValues<Double>> listValidateValues = getCommonValidateValues();
            listValidateValues.Add(new ValidateSizeOfSidesInTriangle());
            return listValidateValues;
        }

        public static List<ValidateValues<Double>> getCommonValidateValues()

        {
            List<ValidateValues<Double>> listValidateValues = new List<ValidateValues<Double>>();
            listValidateValues.Add(new ValidateNegativeValues());
            return listValidateValues;
        }
    }
}
