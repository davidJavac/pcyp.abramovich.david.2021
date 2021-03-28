using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clase1Ejercicio2Vial.adapter.dto;
using Clase1Ejercicio2Vial.adapter.exception;

namespace Clase1.Ejercicio2.Vial.Test
{
    [TestClass]
    public class InputDtoTest
    {

        [TestMethod]
        public void when_input_is_correct_then_validations_run_successfully()
        {
            InputDto input = new InputDto("vial-test.csv");

            input.callValidations();
        }

        [ExpectedException(typeof(NotFilenameDefinedException))]
        [TestMethod]
        public void when_the_name_of_the_file_is_empty_then_throw_exception()
        {
            InputDto input = new InputDto("");

            input.callValidations();
        }

        [ExpectedException(typeof(NotFilenameDefinedException))]
        [TestMethod]
        public void when_the_name_of_the_file_is_null_then_throw_exception()
        {
            InputDto input = new InputDto(null);

            input.callValidations();
        }

    }
}
