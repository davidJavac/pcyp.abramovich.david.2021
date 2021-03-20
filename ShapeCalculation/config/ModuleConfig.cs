using System;
using System.Collections.Generic;
using System.Text;
using ShapeCalculation.adapter.validation;
using ShapeCalculation.adapter.validation.implementation;

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
    }
}
