using System;
using System.Collections.Generic;
using System.Text;
using ShapeCalculation.adapter.dto;

namespace ShapeCalculation.adapter.validation
{
    public interface ValidateInput<Input>
    {
        public void execute(Input input);
    }
}
