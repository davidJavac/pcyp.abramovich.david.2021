using System;
using System.Collections.Generic;
using System.Text;
using ShapeCalculation.usecase.dto;

namespace ShapeCalculation.usecase.validation
{
    interface ValidateAdapter
    {
        public void execute(InputAdapterDto inputAdapterDto);
    }
}
