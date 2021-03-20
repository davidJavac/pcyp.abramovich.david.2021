using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.usecase.dto
{
    class InputDto
    {
        private List<Double> sides;

        public List<double> Sides { get => sides; set => sides = value; }
    }
}
