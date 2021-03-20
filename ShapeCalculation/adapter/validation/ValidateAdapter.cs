using System;
using System.Collections.Generic;
using System.Text;
using ShapeCalculation.adapter.dto;

namespace ShapeCalculation.adapter.validation
{
    interface ValidateAdapter
    {
        public void execute(InputAdapterDto inputAdapterDto);
    }
}
