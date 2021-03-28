using Clase1Ejercicio1Shape.adapter.dto;
using Clase1Ejercicio1Shape.config;
using Clase1Ejercicio1Shape.usecase;
using Clase1Ejercicio1Shape.usecase.dto;
using Clase1Ejercicio1Shape.usecase.implementation;
using Clase1Ejercicio1Shape.usecase.validation;
using Clase1Ejercicio1Shape.util;
using System;
using System.Globalization;


namespace Clase1Ejercicio1Shape.adapter
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
