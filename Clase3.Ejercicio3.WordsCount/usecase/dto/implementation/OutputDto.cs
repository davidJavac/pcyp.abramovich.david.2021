using Clase3.Ejercicio3.WordCount.usecase.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio3.WordsCount.usecase.dto.implementation
{
    class OutputDto : Output
    {
        private Dictionary<String, int> response;

        public OutputDto(Dictionary<String, int> response) {
            this.response = response;
        }
        public override object getResponse()
        {
            return this.response;
        }
        public override void setResponse(object response)
        {
            this.response = (Dictionary<String, int>)response;
        }
    }
}
