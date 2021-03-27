using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio2Vial.adapter.exception
{
    public class NotFilenameDefinedException : Exception
    {
         public NotFilenameDefinedException() : base("The name of the file can not be null") { }
    
    }
}
