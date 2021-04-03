using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3.Ejercicio4.Netflix.usecase.dto
{
    public abstract class Output
    {
        protected String responseStatus;
        protected String message;
        private Dictionary<String, Object> additionalInformation;

        public abstract Object getResponse();
        public abstract void setResponse(Object response);
        public Dictionary<string, object> AdditionalInformation { get => additionalInformation; set => additionalInformation = value; }
        
    }
}
