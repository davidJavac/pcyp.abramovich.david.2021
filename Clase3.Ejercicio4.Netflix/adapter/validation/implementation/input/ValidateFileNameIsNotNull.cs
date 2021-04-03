using Clase3.Ejercicio4.Netflix.adapter.dto;
using Clase3.Ejercicio4.Netflix.adapter.exception;
using Clase3.Ejercicio4.Netflix.usecase.validation;
using System;

namespace Clase3.Ejercicio4.Netflix.config
{
    internal class ValidateFileNameIsNotNull : ValidateInput<InputDto>
    {
        public void execute(InputDto input)
        {
            if (String.IsNullOrEmpty(input.FileName)) {
                throw new NotFilenameDefinedException();
            }
        }
    }
}