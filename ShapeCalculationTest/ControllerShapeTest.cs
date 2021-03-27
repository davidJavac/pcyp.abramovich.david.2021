using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clase1Ejercicio2Vial.adapter;
using Clase1Ejercicio2Vial.adapter.exception;
using Clase1Ejercicio2Vial.adapter.dto;
using System;
using Clase1Ejercicio2Vial.usecase.dto;
using Clase1Ejercicio2Vial.util;

namespace ShapeCalculationTest
{
    [TestClass]
    public class ControllerShapeTest
    {

        [TestMethod]
        public void when_the_input_is_correct_then_it_should_return_a_successfull_response() {

            OutputDto expectedOutput = new OutputDto(
                    ApplicationConstants.ShapeName.SQUARE,
                    ApplicationConstants.Operation.AREA,
                    4,
                    ApplicationConstants.Status.SUCCESS,
                    "Operation ran successfully");

            InputDto inputDto = new InputDto("square", "area", "2");

            ManageInput manageInput = new ControllerShape(inputDto);

            OutputDto response = manageInput.execute();

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

            OutputDto expectedOutput = new OutputDto(
                    "squar",
                    ApplicationConstants.Operation.AREA,
                    0,
                    ApplicationConstants.Status.ERROR,
                    "The name of the shape is not valid");

            InputDto inputDto = new InputDto("squar", "area", "2");

            ManageInput manageInput = new ControllerShape(inputDto);

            OutputDto response = manageInput.execute();

            Assert.IsNotNull(response);
            Assert.AreEqual(expectedOutput.Shape, response.Shape);
            Assert.AreEqual(expectedOutput.Operation, response.Operation);
            Assert.AreEqual(expectedOutput.ResponseStatus, response.ResponseStatus);
            Assert.AreEqual(expectedOutput.ValueResponse, response.ValueResponse);
            Assert.AreEqual(expectedOutput.Message, response.Message);

        }

    }
}
