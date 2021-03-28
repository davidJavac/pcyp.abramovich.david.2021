using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio1Shape.usecase.dto
{
    public class OutputDto
    {
        private String shape;
        private String operation;
        private Double valueResponse;
        private String responseStatus;
        private String message;

        public OutputDto(string shape, string operation, double valueResponse, string responseStatus, string message)
        {
            this.Shape = shape;
            this.Operation = operation;
            this.ValueResponse = valueResponse;
            this.ResponseStatus = responseStatus;
            this.Message = message;
        }

        public string Shape { get => shape; set => shape = value; }
        public string Operation { get => operation; set => operation = value; }
        public double ValueResponse { get => valueResponse; set => valueResponse = value; }
        public string ResponseStatus { get => responseStatus; set => responseStatus = value; }
        public string Message { get => message; set => message = value; }
    }
}
