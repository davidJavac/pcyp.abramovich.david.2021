using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.adapter.exception
{
    class InvalidShapeNameException : Exception
    {
         public InvalidShapeNameException() : base("The name of the shape is not valid") { }
    
    }
}
