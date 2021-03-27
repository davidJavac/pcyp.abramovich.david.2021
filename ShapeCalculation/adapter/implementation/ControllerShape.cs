using System;
using System.Collections.Generic;
using System.Text;
using Clase1Ejercicio2Vial.usecase.dto;
using Clase1Ejercicio2Vial.adapter.dto;
using Clase1Ejercicio2Vial.util;
using Clase1Ejercicio2Vial.adapter.exception;
using Clase1Ejercicio2Vial.adapter.validation;
using Clase1Ejercicio2Vial.config;
using System.Globalization;
using Clase1Ejercicio2Vial.usecase.implementation;
using Clase1Ejercicio2Vial.usecase;
using Clase1Ejercicio2Vial.usecase.validation;

namespace Clase1Ejercicio2Vial.adapter
{
    public class ControllerShape : ValidationInvoker, ManageInput
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
                invokeValidations();

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
        protected override void invokeValidations()
        {
            ModuleConfig.getValidateInputAdapter()
                .ForEach(val => val.execute(new Tuple<string, InputAdapterDto>(inputDto.ShapeName, inputAdapterDto)));
        }

    }
}
