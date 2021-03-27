using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio2Vial.usecase.exception
{
    public class InvalidSizeOfSideException : Exception
    {
        public InvalidSizeOfSideException() : base("The size of the sides is invalid for this shape") { }
    }
}
