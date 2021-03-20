using System;
using System.Collections.Generic;
using System.Text;
using ShapeCalculation.adapter.dto;
using ShapeCalculation.util;
using ShapeCalculation.adapter.exception;
using ShapeCalculation.adapter.validation;
using ShapeCalculation.config;
using System.Globalization;

namespace ShapeCalculation.adapter
{
    class ControllerShape : ValidationInvoker, ManageInput
    {
        private InputDto inputDto;
        private InputAdapterDto inputAdapterDto;
        private Shape shape;
        public ControllerShape(InputDto inputDto) {
            this.inputAdapterDto = new InputAdapterDto();
            this.inputDto = inputDto;
            
        }

        public double getCalculatedValue()
        {
            try { invokeValidations(); } 
            catch (Exception e) { throw e; }

            Factory factory = new FactoryShape();

            shape = factory.create(inputAdapterDto);

            return isAreaOperation(inputAdapterDto.Operation) ? callAreaCalculation() : callPerimeterCalculation();
            
        }

        private bool isAreaOperation(String operation) {
            return (operation.Equals(ApplicationConstants.Operation.AREA, 
                StringComparison.InvariantCultureIgnoreCase));
        }

        private bool isPerimeterOperation(String operation)
        {
            return (operation.Equals(ApplicationConstants.Operation.PERIMETER, 
                StringComparison.InvariantCultureIgnoreCase));
        }

        private void addValuesFromInputToAdapter() {

            inputAdapterDto.Operation = inputDto.Operation;
            inputAdapterDto.ShapeName = inputDto.ShapeName;
            String[] splitedValues = inputDto.Values.Split(",");

            foreach(String s in splitedValues) {
                this.inputAdapterDto.Values.Add(double.Parse(s, CultureInfo.InvariantCulture));
            }
            
        }

        private double callAreaCalculation() {
            shape.calculateArea();
            return shape.getArea();
        }

        private double callPerimeterCalculation()
        {
            shape.calculatePerimeter();
            return shape.getPerimeter();
        }

        protected override void invokeValidations()
        {
            inputDto.callValidations();
            addValuesFromInputToAdapter();
            ModuleConfig.getValidateAdapter().ForEach(val => val.execute(inputAdapterDto));
            
        }
    }
}
