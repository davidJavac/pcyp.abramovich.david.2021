using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio2Vial.adapter.exception
{
    public class InvalidShapeNameException : Exception
    {
         public InvalidShapeNameException() : base("The name of the shape is not valid") { }
    
    }
}
