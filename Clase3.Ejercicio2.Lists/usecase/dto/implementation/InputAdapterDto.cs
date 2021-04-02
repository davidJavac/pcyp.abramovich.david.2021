using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2.Lists.usecase.dto.implementation
{
    class InputAdapterDto : Input
    {
        private List<List<String>> listStrings;
        public override object getValue()
        {
            return this.listStrings;
        }

        public override void setValue(object value)
        {
            this.listStrings = (List<List<String>>)value;
        }

        public String getOperation() {
            return this.operation;
        }

        public void setOperation(String operation) {
            this.operation = operation;
        }
    }
}
