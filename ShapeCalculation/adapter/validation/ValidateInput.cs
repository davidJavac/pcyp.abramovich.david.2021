using System;
using System.Collections.Generic;
using System.Text;
using ShapeCalculation.adapter.dto;

namespace ShapeCalculation.adapter.validation
{
    interface ValidateInput
    {
        public void execute(InputDto input);
    }
}
