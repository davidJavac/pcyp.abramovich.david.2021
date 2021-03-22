using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.adapter.exception
{
    public class InvalidSidesDefinitionException : Exception
    {
         public InvalidSidesDefinitionException() : base("The sides must be separated by comma") { }
    
    }
}
