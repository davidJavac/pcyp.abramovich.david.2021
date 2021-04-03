using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1.Dictionary.usecase.dto
{
    public abstract class Input
    {
        private Dictionary<String, Object> additionalInformation = new Dictionary<string, object>();
        public abstract Object getValue();
        public abstract void setValue(Object value);
        public Dictionary<string, object> AdditionalInformation { get => additionalInformation; set => additionalInformation = value; }
    }
}
