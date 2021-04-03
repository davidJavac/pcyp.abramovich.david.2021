using System;
using System.Collections.Generic;
using System.Text;
using Clase3.Ejercicio4.Netflix.adapter.dto;

namespace Clase3.Ejercicio4.Netflix.usecase.validation
{
    public interface ValidateInput<Input>
    {
        public void execute(Input input);
    }
}
