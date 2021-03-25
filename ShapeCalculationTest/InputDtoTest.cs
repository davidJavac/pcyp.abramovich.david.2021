using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeCalculation;
using ShapeCalculation.adapter.dto;
using ShapeCalculation.adapter.exception;
using ShapeCalculation.adapter.validation.implementation;
using ShapeCalculation.usecase.exception;
using System;

namespace ShapeCalculationTest
{
    [TestClass]
    public class InputDtoTest
    {

        [ExpectedException(typeof(InvalidShapeNameException))]
        [TestMethod]
        public void when_shape_does_not_exist_then_throw_exception()
        {
            InputDto input = new InputDto("squ", "perimeter", "2");

            input.callValidations();
        }

        [ExpectedException(typeof(InvalidOperationNameException))]
        [TestMethod]
        public void when_operation_does_not_exist_then_throw_exception()
        {
            InputDto input = new InputDto("rectangle", "are", "2,2");

            input.callValidations();
        }

        [ExpectedException(typeof(InvalidSidesDefinitionException))]
        [TestMethod]
        public void when_values_are_not_separated_by_comma_then_throw_exception()
        {
            InputDto input = new InputDto("triangle", "area", "2:2;3");

            input.callValidations();
        }

    }
}
