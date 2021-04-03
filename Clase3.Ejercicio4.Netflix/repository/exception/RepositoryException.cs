using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3.Ejercicio4.Netflix.repository.exception
{
    public class RepositoryException : Exception
    {
        public RepositoryException(String message) : base("There was an exception while trying to access the data. Message: " + message) { }
    }
}
