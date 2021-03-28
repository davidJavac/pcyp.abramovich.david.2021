using System;
using System.Collections.Generic;

namespace Clase1Ejercicio1Shape.config
{
    interface Factory
    {
        Shape create(String shapeName, List<Double> values);
    }
}
