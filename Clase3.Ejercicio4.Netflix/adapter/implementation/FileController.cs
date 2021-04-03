using System;
using System.Collections.Generic;
using Clase3.Ejercicio4.Netflix.usecase.dto;
using Clase3.Ejercicio4.Netflix.adapter.dto;
using Clase3.Ejercicio4.Netflix.util;
using Clase3.Ejercicio4.Netflix.config;
using Clase3.Ejercicio4.Netflix.usecase.implementation;
using Clase3.Ejercicio4.Netflix.usecase;
using Clase3.Ejercicio4.Netflix.usecase.validation;
using System.IO;
using Clase3.Ejercicio4.Netflix.core.entity;

namespace Clase3.Ejercicio4.Netflix.adapter
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

                Interactor fileNetflixRatingReader = new FileNetflixRatingReader();

                return fileNetflixRatingReader.execute(inputAdapterDto);
            }
            catch (Exception e) {

                return prepareErrorResponse(e.Message);
            }
            
        }


        private void addValuesFromInputToAdapter() {

            String absolutePath = Path.GetFullPath(ApplicationConstants.Resources.RATING_TXT_FOLDER +
               "\\" + inputDto.FileName);
            inputAdapterDto.Path = absolutePath;
        }

        private Output prepareErrorResponse(string message)
        {
            return new OutputNetflixRatingDto(
                new Dictionary<int, int>(),
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
