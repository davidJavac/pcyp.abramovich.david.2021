using Clase1Ejercicio2Vial.usecase.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio2Vial.usecase
{
    public interface Interactor
    {
        public Output execute(InputAdapterDto input);
    }
}
