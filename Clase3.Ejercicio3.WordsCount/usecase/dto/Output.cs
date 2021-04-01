using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio3.WordCount.usecase.dto
{
    public abstract class Output
    {
        public abstract Object getResponse();
        public abstract void setResponse(Object response);
    }
}
