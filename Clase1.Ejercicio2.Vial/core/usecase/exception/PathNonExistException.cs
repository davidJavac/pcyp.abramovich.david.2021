using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio2Vial.usecase.exception
{
    public class PathNonExistException : Exception
    {
        public PathNonExistException() : base("The given file name does not exist") { }
    }
}
