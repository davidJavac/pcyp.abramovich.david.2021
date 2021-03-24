using System;
using ShapeCalculation.adapter;
using ShapeCalculation.adapter.dto;
using ShapeCalculation.adapter.implementation;
using ShapeCalculation.adapter.view;
using ShapeCalculation.adapter.view.implementation;
using ShapeCalculation.usecase.dto;

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
            ManageInput manageInput = new ControllerShape(inputDto);

            OutputDto response = manageInput.execute();

            ManageOutput manageOutput = new PresenterResponse();
            manageOutput.execute(response);

        }
    }
}
