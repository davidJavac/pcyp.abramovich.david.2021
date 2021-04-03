using Clase3.Ejercicio1.Dictionary.usecase.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1.Dictionary.usecase
{
    interface CollectionProcess
    {
        public Output execute(Input input);
    }
}
