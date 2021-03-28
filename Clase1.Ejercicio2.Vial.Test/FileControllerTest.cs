using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clase1Ejercicio2Vial.adapter;
using Clase1Ejercicio2Vial.adapter.dto;
using System;
using Clase1Ejercicio2Vial.usecase.dto;
using Clase1Ejercicio2Vial.util;
using System.Collections.Generic;
using Clase1Ejercicio2Vial.core.entity;

namespace Clase1.Ejercicio2.Vial.Test
{
    [TestClass]
    public class FileControllerTest
    {
        private VialDto expectedVial;

        [TestInitialize]
        public void TestInitialize()
        {
            int n_sheet = 2554;
            String objectType = "Red Vial";
            int idSection = 69720;
            String pathType = "Camino terciario";
            int lenght = 18;

            expectedVial = new VialDto(n_sheet, objectType, idSection, pathType, lenght);

        }

        [TestMethod]
        public void when_the_input_is_correct_then_it_should_return_a_successfull_response() {

            List<VialDto> list = new List<VialDto>();
            list.Add(expectedVial);

            Output output = new OutputVialDto(list,
                ApplicationConstants.Status.SUCCESS,
                "Operation ran successfully");

            OutputVialDto expectedOutput = (OutputVialDto)output;

            InputDto inputDto = new InputDto("vial-test.csv");

            ManageInput manageInput = new FileController(inputDto);

            Output result = manageInput.execute();
            OutputVialDto resultOutput = (OutputVialDto)result;

            VialDto resultVial = ((List<VialDto>)resultOutput.getResponse())[0];

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedVial.N_sheet, resultVial.N_sheet);
            Assert.AreEqual(expectedVial.ObjectType, resultVial.ObjectType);
            Assert.AreEqual(expectedVial.IdSection, resultVial.IdSection);
            Assert.AreEqual(expectedVial.PathType, resultVial.PathType);
            Assert.AreEqual(expectedVial.Lenght, resultVial.Lenght);

            Assert.AreEqual(expectedOutput.getResponseStatus(), resultOutput.getResponseStatus());
            Assert.AreEqual(expectedOutput.getMessage(), resultOutput.getMessage());

        }

        [TestMethod]
        public void when_the_input_is_not_correct_then_it_should_return_an_error_response()
        {

            List<VialDto> list = new List<VialDto>();
            list.Add(expectedVial);

            Output output = new OutputVialDto(
                new List<VialDto>(),
                ApplicationConstants.Status.ERROR,
                "The given file name does not exist");

            OutputVialDto expectedOutput = (OutputVialDto)output;

            InputDto inputDto = new InputDto("starwars.csv");

            ManageInput manageInput = new FileController(inputDto);

            Output result = manageInput.execute();
            OutputVialDto resultOutput = (OutputVialDto)result;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedOutput.getResponseStatus(), resultOutput.getResponseStatus());
            Assert.AreEqual(expectedOutput.getMessage(), resultOutput.getMessage());

        }

    }
}
