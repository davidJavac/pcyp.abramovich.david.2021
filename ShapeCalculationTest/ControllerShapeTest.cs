using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeCalculation.adapter;
using ShapeCalculation.adapter.exception;
using ShapeCalculation.adapter.dto;
using System;

namespace ShapeCalculationTest
{
    [TestClass]
    public class ControllerShapeTest
    {
        [TestInitialize]
        public void testInitialize() { 
            
        }

        [TestMethod]
        public void when_the_input_is_correct_then_it_should_return_double_value() { 

            InputDto inputDto = new InputDto("square", "area", "2.5");

            ControllerShape controllerShape = new ControllerShape(inputDto);

            double valueResponse = controllerShape.getCalculatedValue();

            Assert.IsNotNull(valueResponse);
         
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidAmountOfSidesException))]
        public void when_the_input_amount_sides_is_not_correct_then_it_should_throw_exception()
        {

            InputDto inputDto = new InputDto("square", "area", "2.5,4");

            ControllerShape controllerShape = new ControllerShape(inputDto);

            controllerShape.getCalculatedValue();

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidShapeNameException))]
        public void when_the_input_shape_name_is_not_correct_then_it_should_throw_exception()
        {

            InputDto inputDto = new InputDto("circle", "area", "2.5");

            ControllerShape controllerShape = new ControllerShape(inputDto);

            controllerShape.getCalculatedValue();

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationNameException))]
        public void when_the_input_operation_name_is_not_correct_then_it_should_throw_exception()
        {

            InputDto inputDto = new InputDto("square", "ratio", "2.5");

            ControllerShape controllerShape = new ControllerShape(inputDto);

            controllerShape.getCalculatedValue();

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSidesDefinitionException))]
        public void when_the_input_amount_sides_is_higer_than_one_and_is_not_separated_by_comma__then_it_should_throw_exception()
        {

            InputDto inputDto = new InputDto("triangle", "perimeter", "2.5:3");

            ControllerShape controllerShape = new ControllerShape(inputDto);

            controllerShape.getCalculatedValue();

        }
    }
}
