﻿using Clase3.Ejercicio4.Netflix.core.entity;
using System;
using System.Collections.Generic;

namespace Clase3.Ejercicio4.Netflix.usecase.dto
{
    public class OutputNetflixRatingPresenterDto : Output
    {
        private SortedDictionary<int, int> response;

        public OutputNetflixRatingPresenterDto(SortedDictionary<int, int> response, String responseStatus, String message)
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
            this.response = (SortedDictionary<int, int>)response;
        }

        public String getResponseStatus() {
            return this.responseStatus;
        }
        public String getMessage() {
            return this.message;
        }
    }
}
