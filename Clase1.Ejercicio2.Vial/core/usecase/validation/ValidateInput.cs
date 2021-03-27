using System;
using System.Collections.Generic;
using System.Text;
using Clase1Ejercicio2Vial.adapter.dto;

namespace Clase1Ejercicio2Vial.usecase.validation
{
    public interface ValidateInput<Input>
    {
        public void execute(Input input);
    }
}
