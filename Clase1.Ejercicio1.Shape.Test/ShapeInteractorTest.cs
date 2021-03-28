using Clase1Ejercicio1Shape;
using Clase1Ejercicio1Shape.config;
using Clase1Ejercicio1Shape.usecase;
using Clase1Ejercicio1Shape.usecase.dto;
using Clase1Ejercicio1Shape.usecase.implementation;
using Clase1Ejercicio1Shape.util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace ShapeCalculationTest
{
    [TestClass]
    public class ShapeInteractorTest
    {

        [TestMethod]
        public void when_the_input_is_correct_then_it_should_return_a_successfull_response() {

            String shapeName = ApplicationConstants.ShapeName.SQUARE;

            OutputDto expectedOutput = new OutputDto(
                    shapeName,
                    ApplicationConstants.Operation.AREA,
                    4,
                    ApplicationConstants.Status.SUCCESS,
                    "Operation ran successfully");

            List<Double> values = new List<Double>();
            values.Add(2);

            Shape shape = ModuleConfig.createShape(shapeName, values);
            InputAdapterDto input = new InputAdapterDto(shape, "area", values);

            Interactor shapeInteractor = new ShapeInteractor();

            OutputDto response = shapeInteractor.execute(input);

            Assert.IsNotNull(response);
            Assert.AreEqual(expectedOutput.Shape, response.Shape);
            Assert.AreEqual(expectedOutput.Operation, response.Operation);
            Assert.AreEqual(expectedOutput.ResponseStatus, response.ResponseStatus);
            Assert.AreEqual(expectedOutput.ValueResponse, response.ValueResponse);
            Assert.AreEqual(expectedOutput.Message, response.Message);

        }

        [TestMethod]
        public void when_the_input_is_not_correct_then_it_should_return_an_error_response()
        {
            String shapeName = "triangle";
            String operation = "area";

            OutputDto expectedOutput = new OutputDto(
                    shapeName,
                    ApplicationConstants.Operation.AREA,
                    0,
                    ApplicationConstants.Status.ERROR,
                    "The values of the sides must not be negative");

            double valueA = 2;
            double valueB = -1;
            double valueC = 2;

            List<Double> values = new List<Double>();
            values.Add(valueA);
            values.Add(valueB);
            values.Add(valueC);

            Shape shape = new Triangle(valueA, valueB, valueC);
            InputAdapterDto input = new InputAdapterDto(shape, operation, values);

            Interactor shapeInteractor = new ShapeInteractor();

            OutputDto response = shapeInteractor.execute(input);

            Assert.IsNotNull(response);
            Assert.AreEqual(expectedOutput.Shape, response.Shape);
            Assert.AreEqual(expectedOutput.Operation, response.Operation);
            Assert.AreEqual(expectedOutput.ResponseStatus, response.ResponseStatus);
            Assert.AreEqual(expectedOutput.ValueResponse, response.ValueResponse);
            Assert.AreEqual(expectedOutput.Message, response.Message);

        }

    }
}
