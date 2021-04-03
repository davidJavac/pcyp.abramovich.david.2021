using Clase3.Ejercicio2.Lists.usecase.dto;
using Clase3.Ejercicio2.Lists.usecase.dto.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2.Lists.interface_adapter
{
    interface ManageCollection
    {
        public void execute(InputDto input);
    }
}
