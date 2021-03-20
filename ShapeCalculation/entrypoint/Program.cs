using System;
using ShapeCalculation.adapter;
using ShapeCalculation.adapter.dto;

namespace ShapeCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of the shape:");
            string shapeName = Console.ReadLine();
            Console.WriteLine("Enter the value of the sides:");
            string sideValues = Console.ReadLine();
            Console.WriteLine("Enter the operation:");
            string operation = Console.ReadLine();

            InputDto inputDto = new InputDto(shapeName, operation, sideValues);
            Input input = new ControllerShape();
            input.getValue(inputDto);

        }
    }
}
