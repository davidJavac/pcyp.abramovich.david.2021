using Clase1Ejercicio1Shape.adapter.dto;
using Clase1Ejercicio1Shape.adapter.exception;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ShapeCalculationTest
{
    [TestClass]
    public class InputDtoTest
    {

        [TestMethod]
        public void when_input_is_correct_then_validations_run_successfully()
        {
            InputDto input = new InputDto("triangle", "area", "2,2,2");

            input.callValidations();
        }

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
