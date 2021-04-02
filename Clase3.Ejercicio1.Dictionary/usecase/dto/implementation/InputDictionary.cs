using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1.Dictionary.usecase.dto.implementation
{
    class InputDictionary : Input
    {
        private Dictionary<String, String> value;

        public InputDictionary(Dictionary<String, String> value) {
            this.value = value;
    
        }

        public override object getValue()
        {
            return this.value;
        }

        public override void setValue(object value)
        {
            this.value = (Dictionary<String, String>)value;
        }

    }
}
