using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.usecase.dto
{
    public class InputAdapterDto
    {
        private Shape shape;
        private String operation;
        private List<Double> values;

        public InputAdapterDto() {
            this.values = new List<Double>();
        }

        public InputAdapterDto(Shape shape, String operation, List<Double> values) {
            this.shape = shape;
            this.operation = operation;
            this.values = values;
        }

        public Shape Shape { get => shape; set => shape = value; }
        public string Operation { get => operation; set => operation = value; }
        public List<double> Values { get => values; set => values = value; }
       
    }
}
