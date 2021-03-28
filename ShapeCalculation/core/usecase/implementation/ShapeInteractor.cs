using Clase1Ejercicio2Vial.config;
using Clase1Ejercicio2Vial.usecase.dto;
using Clase1Ejercicio2Vial.usecase.validation;
using Clase1Ejercicio2Vial.util;
using System;


namespace Clase1Ejercicio1Shape.usecase.implementation
{
    public class ShapeInteractor : ValidationInvoker, Interactor
    {
        private Shape shape;
        private InputAdapterDto input;

        public OutputDto execute(InputAdapterDto input)
        {
            try
            {
                this.input = input;

                invokeValidations();

                shape = this.input.Shape;

                double response = isAreaOperation(input.Operation) ? callAreaCalculation() : callPerimeterCalculation();

                return prepareSuccessfullResponse(response);

            }
            catch (Exception e) {

                return prepareErrorResponse(e.Message);
            }
            
        }

        private bool isAreaOperation(String operation)
        {
            return (operation.Equals(ApplicationConstants.Operation.AREA,
                StringComparison.InvariantCultureIgnoreCase));
        }

        private bool isPerimeterOperation(String operation)
        {
            return (operation.Equals(ApplicationConstants.Operation.PERIMETER,
                StringComparison.InvariantCultureIgnoreCase));
        }

        private double callAreaCalculation()
        {
            shape.calculateArea();
            return shape.getArea();
        }

        private double callPerimeterCalculation()
        {
            shape.calculatePerimeter();
            return shape.getPerimeter();
        }

        private OutputDto prepareSuccessfullResponse(double response) {
            return new OutputDto(this.input.Shape.getName(),
                    this.input.Operation,
                    response,
                    ApplicationConstants.Status.SUCCESS,
                    "Operation ran successfully");
            
        }
        private OutputDto prepareErrorResponse(string message)
        {
            return new OutputDto(this.input.Shape.getName(),
                    this.input.Operation,
                    0,
                    ApplicationConstants.Status.ERROR,
                    message);
            
        }

        protected override void invokeValidations()
        {
            ModuleConfig.getCommonValidateValues().ForEach(val => val.execute(input.Values.ToArray()));
        }

    }
}
