using Clase1Ejercicio1Shape.adapter;
using Clase1Ejercicio1Shape.adapter.dto;
using Clase1Ejercicio1Shape.adapter.implementation;
using Clase1Ejercicio1Shape.usecase.dto;
using System;


namespace Clase1Ejercicio1Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of the shape:");
            string shapeName = Console.ReadLine();
            Console.WriteLine("Enter the values of the sides, " +
                "separated by comma if it's necessary(square:1, rectangle:2, triangle:3):");
            string sideValues = Console.ReadLine();
            Console.WriteLine("Enter the operation:");
            string operation = Console.ReadLine();

            InputDto inputDto = new InputDto(shapeName, operation, sideValues);
            ManageInput manageInput = new ControllerShape(inputDto);

            OutputDto response = manageInput.execute();

            ManageOutput manageOutput = new PresenterResponse();
            manageOutput.execute(response);

        }
    }
}
