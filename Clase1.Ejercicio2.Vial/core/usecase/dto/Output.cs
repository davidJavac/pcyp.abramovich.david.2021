using Clase1.Ejercicio2.Vial.core.usecase.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio2Vial.usecase.dto
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
