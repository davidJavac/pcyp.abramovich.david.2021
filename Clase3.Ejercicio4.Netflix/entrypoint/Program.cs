using System;
using Clase3.Ejercicio4.Netflix.adapter;
using Clase3.Ejercicio4.Netflix.adapter.dto;
using Clase3.Ejercicio4.Netflix.adapter.implementation;
using Clase3.Ejercicio4.Netflix.usecase.dto;

namespace Clase3.Ejercicio4.Netflix
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

            ManageOutput manageOutput = new PresenterNetflixResponse();
            manageOutput.execute(response);

        }
    }
}
