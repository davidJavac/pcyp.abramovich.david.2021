using System;
using Clase1Ejercicio2Vial.adapter;
using Clase1Ejercicio2Vial.adapter.dto;
using Clase1Ejercicio2Vial.adapter.implementation;
using Clase1Ejercicio2Vial.usecase.dto;

namespace Clase1Ejercicio2Vial
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
