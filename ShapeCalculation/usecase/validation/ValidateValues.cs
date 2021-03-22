using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.usecase.validation
{
    interface ValidateValues<Type>
    {
        public void execute(params Type [] values);
    }
}
