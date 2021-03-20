using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.adapter.dto
{
    class InputAdapterDto
    {
        private String shapeName;
        private String operation;
        private List<Double> values;

        public InputAdapterDto() {
            this.values = new List<Double>();
        }

        public InputAdapterDto(String shapeName, String operation, List<Double> values) {
            this.shapeName = shapeName;
            this.operation = operation;
            this.values = values;
        }

        public string ShapeName { get => shapeName; set => shapeName = value; }
        public string Operation { get => operation; set => operation = value; }
        public List<double> Values { get => values; set => values = value; }
    }
}
