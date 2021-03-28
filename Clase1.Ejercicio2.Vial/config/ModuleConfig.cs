using System.Collections.Generic;
using Clase1.Ejercicio2.Vial.core.repository;
using Clase1.Ejercicio2.Vial.repository;
using Clase1Ejercicio2Vial.adapter.dto;
using Clase1Ejercicio2Vial.usecase.dto;
using Clase1Ejercicio2Vial.usecase.validation;
using Clase1Ejercicio2Vial.usecase.validation.implementation;


namespace Clase1Ejercicio2Vial.config
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
        public static GetAllVialRepository getAllVialRepository() {

            return new GetAllVialResourcesRepository();
        }
    }
}
