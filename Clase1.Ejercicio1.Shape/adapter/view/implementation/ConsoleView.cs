using Clase1Ejercicio1Shape.usecase.dto;
using System;

namespace Clase1Ejercicio1Shape.adapter.view.implementation
{
    class ConsoleView : ViewPresenter
    {
        public void execute(OutputDto output)
        {
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("Response of the process");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\nStatus: " + output.ResponseStatus);
            Console.WriteLine("Message: " + output.Message);
            Console.WriteLine("Operation: " + output.Operation);
            Console.WriteLine("Shape: " + output.Shape);
            Console.WriteLine("Value: " + output.ValueResponse);
            Console.WriteLine("\n-----------------------------------------------");
        }
    }
}
