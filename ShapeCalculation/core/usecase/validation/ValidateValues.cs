using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio1Shape.core.usecase.validation
{
    public interface ValidateValues<Type>
    {
        public void execute(params Type[] values);
    }
}
