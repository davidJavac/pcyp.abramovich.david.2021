using Clase1Ejercicio2Vial.adapter.dto;
using Clase1Ejercicio2Vial.usecase.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio2Vial.adapter.view.implementation
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
