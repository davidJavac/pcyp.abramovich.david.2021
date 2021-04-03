using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3.Ejercicio4.Netflix.usecase.exception
{
    public class PathNonExistException : Exception
    {
        public PathNonExistException() : base("The given file name does not exist") { }
    }
}
