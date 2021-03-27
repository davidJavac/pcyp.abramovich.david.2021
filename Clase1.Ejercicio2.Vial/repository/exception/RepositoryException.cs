using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio2Vial.repository.exception
{
    public class RepositoryException : Exception
    {
        public RepositoryException(String message) : base("There was an exception while trying to access the data. Message: " + message) { }
    }
}
