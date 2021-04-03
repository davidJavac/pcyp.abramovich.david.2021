using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2.Lists.usecase.dto
{
    public abstract class Output
    {
        protected String operation;
        public abstract Object getResponse();
        public abstract void setResponse(Object response);
    }
}
