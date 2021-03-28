using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio1Shape.usecase.exception
{
    public class NegativeValueException : Exception
    {
        public NegativeValueException() : base("The values of the sides must not be negative") { }
    }
}
