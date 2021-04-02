using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1.Dictionary.usecase.dto.implementation
{
    class OutputDictionary : Output
    {
        private String response;
        private String operation;
        public OutputDictionary(String response, String operation) {
            this.response = response;
            this.operation = operation;
        }


        public override object getResponse()
        {
            return this.response;
        }

        public override void setResponse(object response)
        {
            this.response = (String)response;
        }
        public string Operation { get => operation; set => operation = value; }
    }
}
