using ShapeCalculation.adapter.dto;
using ShapeCalculation.usecase.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.config
{
    interface Factory
    {
        Shape create(String shapeName, List<Double> values);
    }
}
