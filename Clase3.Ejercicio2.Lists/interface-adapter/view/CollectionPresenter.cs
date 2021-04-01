using Clase3.Ejercicio2.Lists.usecase.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2.Lists.interface_adapter.view
{
    interface CollectionPresenter
    {
        public void present(Output output);
    }
}
