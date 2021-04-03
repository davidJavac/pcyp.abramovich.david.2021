using Clase3.Ejercicio4.Netflix.usecase.dto;
using System.IO;
using Clase3.Ejercicio4.Netflix.usecase.exception;

namespace Clase3.Ejercicio4.Netflix.usecase.validation.implementation
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
