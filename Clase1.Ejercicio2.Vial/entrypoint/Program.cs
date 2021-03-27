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
            Console.WriteLine("Enter the name of the file:");
            string fileName = Console.ReadLine();
           
            InputDto inputDto = new InputDto(fileName);
            ManageInput manageInput = new FileController(inputDto);

            Output response = manageInput.execute();

            ManageOutput manageOutput = new PresenterVialResponse();
            manageOutput.execute(response);

        }
    }
}
