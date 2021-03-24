using System;
using System.Collections.Generic;
using System.Text;
using ShapeCalculation.usecase.dto;
using ShapeCalculation.adapter.dto;
using ShapeCalculation.util;
using ShapeCalculation.adapter.exception;
using ShapeCalculation.adapter.validation;
using ShapeCalculation.config;
using System.Globalization;
using ShapeCalculation.usecase.implementation;
using ShapeCalculation.usecase;

namespace ShapeCalculation.adapter
{
    public class ControllerShape : ManageInput
    {
        private InputDto inputDto;
        private InputAdapterDto inputAdapterDto;
        
        public ControllerShape(InputDto inputDto) {
            this.inputAdapterDto = new InputAdapterDto();
            this.inputDto = inputDto;
            
        }

        public OutputDto execute()
        {
            try
            {
                inputDto.callValidations();
                addValuesFromInputToAdapter();

                Shape shape = ModuleConfig.createShape(inputDto.ShapeName, inputAdapterDto.Values);

                inputAdapterDto.Shape = shape;

                Interactor shapeInteractor = new ShapeInteractor();

                return shapeInteractor.execute(inputAdapterDto);
            }
            catch (Exception e) {

                return prepareErrorResponse(e.Message);
            }
            
        }

        private void addValuesFromInputToAdapter() {

            inputAdapterDto.Operation = inputDto.Operation;
            
            String[] splitedValues = inputDto.Values.Split(",");

            foreach(String s in splitedValues) {
                this.inputAdapterDto.Values.Add(double.Parse(s, CultureInfo.InvariantCulture));
            }
            
        }

        private OutputDto prepareErrorResponse(string message)
        {
            return new OutputDto(inputDto.ShapeName,
                inputDto.Operation,
                0,
                ApplicationConstants.Status.ERROR,
                message);

        }

    }
}
