using ShapeCalculation.adapter.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.adapter
{
    interface Factory
    {
        Shape create(InputAdapterDto inputAdapterDto);
    }
}
