using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2.Lists.usecase.dto.implementation
{
    class OutputListDto : Output
    {
        private List<String> response;

        public OutputListDto(List<String> response, String operation) {
            this.response = response;
            this.operation = operation;
        }
        public override object getResponse()
        {
            return response;
        }

        public override void setResponse(object response)
        {
            this.response = (List<String>)response;
        }

        public String getOperation() { 
            return this.operation;
        }
    }
}
