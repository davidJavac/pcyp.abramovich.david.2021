using System;
using System.Collections.Generic;
using System.Text;
using Clase1Ejercicio2Vial.usecase.dto;
using Clase1Ejercicio2Vial.adapter.dto;
using Clase1Ejercicio2Vial.util;
using Clase1Ejercicio2Vial.adapter.exception;
using Clase1Ejercicio2Vial.config;
using System.Globalization;
using Clase1Ejercicio2Vial.usecase.implementation;
using Clase1Ejercicio2Vial.usecase;
using Clase1Ejercicio2Vial.usecase.validation;
using System.IO;
using Clase1.Ejercicio2.Vial.core.usecase.dto;

namespace Clase1Ejercicio2Vial.adapter
{
    public class FileController : ValidationInvoker, ManageInput
    {
        private InputDto inputDto;
        private InputAdapterDto inputAdapterDto;
        
        public FileController(InputDto inputDto) {
            this.inputAdapterDto = new InputAdapterDto();
            this.inputDto = inputDto;
            
        }

        public Output execute()
        {
            try
            {
                inputDto.callValidations();
                addValuesFromInputToAdapter();
                invokeValidations();

                Interactor fileVialReader = new FileVialReader();

                return fileVialReader.execute(inputAdapterDto);
            }
            catch (Exception e) {

                return prepareErrorResponse(e.Message);
            }
            
        }


        private void addValuesFromInputToAdapter() {

            String absolutePath = Path.GetFullPath(ApplicationConstants.Resources.VIAL_CSV_FOLDER +
               "\\" + inputDto.FileName);
            inputAdapterDto.Path = absolutePath;
        }

        private Output prepareErrorResponse(string message)
        {
            return new OutputVialDto(
                new List<VialDto>(),
                ApplicationConstants.Status.ERROR,
                message);

        }
        protected override void invokeValidations()
        {
            ModuleConfig.getValidateInputAdapter()
                .ForEach(val => val.execute(inputAdapterDto));
        }

    }
}
