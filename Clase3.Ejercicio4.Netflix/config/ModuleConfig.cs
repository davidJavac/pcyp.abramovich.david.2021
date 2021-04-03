using System.Collections.Generic;
using Clase3.Ejercicio4.Netflix.core.repository;
using Clase3.Ejercicio4.Netflix.repository;
using Clase3.Ejercicio4.Netflix.adapter.dto;
using Clase3.Ejercicio4.Netflix.usecase.dto;
using Clase3.Ejercicio4.Netflix.usecase.validation;
using Clase3.Ejercicio4.Netflix.usecase.validation.implementation;


namespace Clase3.Ejercicio4.Netflix.config
{
    public class ModuleConfig
    {
        //validations-------------------------------------------------------------------------------
        public static List<ValidateInput<InputDto>> getValidateInput() {
            List<ValidateInput<InputDto>> listValidateInput = new List<ValidateInput<InputDto>>();
            listValidateInput.Add(new ValidateFileNameIsNotNull());
            
            return listValidateInput;
        }

        public static List<ValidateInput<InputAdapterDto>> getValidateInputAdapter()
        {
            List<ValidateInput<InputAdapterDto>> listValidateAdapter = new List<ValidateInput<InputAdapterDto>>();
            listValidateAdapter.Add(new ValidateFileExists());
            return listValidateAdapter;
        }

        //repository--------------------------------------------------------------------------------
        public static GetAllNetflixRatingRepository getAllNetflixRatingRepository() {

            return new GetAllNetflixRatingResourcesRepository();
        }
    }
}
