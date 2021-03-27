using Clase1Ejercicio2Vial.usecase.dto;
using System.IO;
using Clase1Ejercicio2Vial.usecase.exception;

namespace Clase1Ejercicio2Vial.usecase.validation.implementation
{
    class ValidateFileExists : ValidateInput<InputAdapterDto>
    {
        public void execute(InputAdapterDto inputAdapterDto)
        {

            if (!File.Exists(inputAdapterDto.Path))
            {
                throw new PathNonExistException();
            }
            
        }
    }
}
