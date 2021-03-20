using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.adapter.exception
{
    class InvalidAmountOfSidesException : Exception
    {
        public InvalidAmountOfSidesException(String shapeName) : base("The amount of sides is invalid for the shape " + shapeName) {}
    }
}
