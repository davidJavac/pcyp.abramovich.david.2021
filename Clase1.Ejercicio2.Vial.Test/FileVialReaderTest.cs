using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clase1Ejercicio2Vial.adapter;
using Clase1Ejercicio2Vial.adapter.exception;
using Clase1Ejercicio2Vial.adapter.dto;
using System;
using Clase1Ejercicio2Vial.usecase.dto;
using Clase1Ejercicio2Vial.util;
using Clase1.Ejercicio2.Vial.core.usecase.dto;
using System.Collections.Generic;
using Clase1.Ejercicio2.Vial.core.repository;
using Clase1Ejercicio2Vial.usecase;
using Clase1Ejercicio2Vial.usecase.implementation;
using System.IO;
using Clase1Ejercicio2Vial.core.entity;

namespace Clase1.Ejercicio2.Vial.Test
{
    [TestClass]
    public class FileVialReaderTest
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

            String absolutePath = Path.GetFullPath(ApplicationConstants.Resources.VIAL_CSV_FOLDER +
               "\\" + "vial-test.csv");

            InputAdapterDto inputDto = new InputAdapterDto();
            inputDto.Path = absolutePath;

            Interactor interactor = new FileVialReader();

            Output result = interactor.execute(inputDto);
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
        public void when_the_path_is_not_correct_then_it_should_return_an_error_response()
        {

            List<VialDto> list = new List<VialDto>();
            list.Add(expectedVial);
            String fileName = "vial-tst.csv";
            String expectedMessage = "There was an exception while trying to access the data. Message: Could not find file '" +
                Path.GetFullPath(ApplicationConstants.Resources.VIAL_CSV_FOLDER + "\\" + fileName) + "'.";
            Output output = new OutputVialDto(
                new List<VialDto>(),
                ApplicationConstants.Status.ERROR,
                expectedMessage);

            OutputVialDto expectedOutput = (OutputVialDto)output;

            String absolutePath = Path.GetFullPath(ApplicationConstants.Resources.VIAL_CSV_FOLDER +
               "\\" + fileName);

            InputAdapterDto inputDto = new InputAdapterDto();
            inputDto.Path = absolutePath;

            Interactor interactor = new FileVialReader();

            Output result = interactor.execute(inputDto);
            OutputVialDto resultOutput = (OutputVialDto)result;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedOutput.getResponseStatus(), resultOutput.getResponseStatus());
            Assert.AreEqual(expectedOutput.getMessage(), resultOutput.getMessage());

        }

    }
}
