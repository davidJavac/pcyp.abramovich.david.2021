using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.adapter
{
    interface Factory
    {
        Shape create(String shape, List<Double> values);
    }
}
