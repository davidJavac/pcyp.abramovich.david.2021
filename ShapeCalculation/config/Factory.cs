using Clase1Ejercicio2Vial.adapter.dto;
using Clase1Ejercicio2Vial.usecase.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio1Shape.config
{
    interface Factory
    {
        Shape create(String shapeName, List<Double> values);
    }
}
