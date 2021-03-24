using ShapeCalculation.adapter.dto;
using ShapeCalculation.usecase.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.adapter
{
    interface ManageOutput
    {
        public void execute(OutputDto output);
    }
}
