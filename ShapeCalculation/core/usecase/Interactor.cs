using ShapeCalculation.usecase.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.usecase
{
    interface Interactor
    {
        public OutputDto execute(InputAdapterDto input);
    }
}
