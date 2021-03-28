using Clase1Ejercicio2Vial.usecase.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio1Shape.usecase
{
    public interface Interactor
    {
        public OutputDto execute(InputAdapterDto input);
    }
}
