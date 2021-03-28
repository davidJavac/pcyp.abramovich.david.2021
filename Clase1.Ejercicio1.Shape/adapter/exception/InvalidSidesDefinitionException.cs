using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio1Shape.adapter.exception
{
    public class InvalidSidesDefinitionException : Exception
    {
         public InvalidSidesDefinitionException() : base("The sides must be separated by comma") { }
    
    }
}
