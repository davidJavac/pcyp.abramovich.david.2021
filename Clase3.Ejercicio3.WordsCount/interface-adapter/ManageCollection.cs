using Clase3.Ejercicio3.WordCount.usecase.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio3.WordCount.interface_adapter
{
    interface ManageCollection
    {
        public void execute(Input input);
    }
}
