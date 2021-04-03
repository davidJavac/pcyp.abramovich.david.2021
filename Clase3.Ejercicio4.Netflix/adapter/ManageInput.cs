using Clase3.Ejercicio4.Netflix.usecase.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3.Ejercicio4.Netflix.adapter
{
    public interface ManageInput
    {
        public Output execute();
    }
}
