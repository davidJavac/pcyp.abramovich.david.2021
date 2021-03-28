using Clase1.Ejercicio2.Vial.core.repository;
using Clase1Ejercicio2Vial.config;
using Clase1Ejercicio2Vial.core.entity;
using Clase1Ejercicio2Vial.usecase.dto;
using Clase1Ejercicio2Vial.usecase.validation;
using Clase1Ejercicio2Vial.util;
using System;
using System.Collections.Generic;

namespace Clase1Ejercicio2Vial.usecase.implementation
{
    public class FileVialReader : ValidationInvoker, Interactor
    {
        private InputAdapterDto input;
        private GetAllVialRepository getAllVialRepository;

        public Output execute(InputAdapterDto input)
        {
            try
            {
                this.input = input;

                getAllVialRepository = createGetAllVialRepository();

                List<VialDto> listVialDto = getAllVialRepository.execute(input.Path);
                
                return prepareSuccessfullResponse(listVialDto);

            }
            catch (Exception e) {

                return prepareErrorResponse(e.Message);
            }
            
        }

        private OutputVialDto prepareSuccessfullResponse(List<VialDto> response) {
            return new OutputVialDto(response,
                ApplicationConstants.Status.SUCCESS,
                "Operation ran successfully");
            
        }
        private OutputVialDto prepareErrorResponse(string message)
        {
            return new OutputVialDto(null,
                ApplicationConstants.Status.ERROR,
                message);
            
        }

        private GetAllVialRepository createGetAllVialRepository() {
            return ModuleConfig.getAllVialRepository();
        }

        protected override void invokeValidations()
        {
        }

    }
}
