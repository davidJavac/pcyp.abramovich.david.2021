using Clase1Ejercicio2Vial.adapter.dto;
using Clase1Ejercicio2Vial.adapter.exception;
using Clase1Ejercicio2Vial.usecase.validation;
using System;

namespace Clase1Ejercicio2Vial.config
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