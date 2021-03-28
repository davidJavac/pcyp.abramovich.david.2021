using Clase1Ejercicio2Vial.core.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio2Vial.usecase.dto
{
    public class OutputVialDto : Output
    {
        private List<VialDto> response;

        public OutputVialDto(List<VialDto> response, String responseStatus, String message)
        {
            this.response = response;
            this.responseStatus = responseStatus;
            this.message = message;
            this.AdditionalInformation = new Dictionary<string, object>();
        }

        public override Object getResponse()
        {
            return response;
        }

        public override void setResponse(Object response)
        {
            this.response = (List<VialDto>)response;
        }

        public String getResponseStatus() {
            return this.responseStatus;
        }
        public String getMessage() {
            return this.message;
        }
    }
}
