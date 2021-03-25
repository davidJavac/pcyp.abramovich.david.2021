using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.core.usecase.validation
{
    public interface ValidateValues<Type>
    {
        public void execute(params Type[] values);
    }
}
