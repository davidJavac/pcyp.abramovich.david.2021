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
            Console.WriteLine("Enter the values of the sides, " +
                "separated by comma if it's necessary(square:1, rectangle:2, triangle:3):");
            string sideValues = Console.ReadLine();
            Console.WriteLine("Enter the operation:");
            string operation = Console.ReadLine();

            InputDto inputDto = new InputDto(shapeName, operation, sideValues);
            ManageInput input = new ControllerShape(inputDto);

            try
            {
                double response = input.getCalculatedValue();
                Console.WriteLine(response);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}
