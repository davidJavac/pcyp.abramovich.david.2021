using Clase3.Ejercicio1.Dictionary.usecase.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1.Dictionary.interface_adapter
{
    interface ManageCollection
    {
        public void execute(Input input);
    }
}
