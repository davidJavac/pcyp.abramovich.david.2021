using Clase3.Ejercicio4.Netflix.usecase.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3.Ejercicio4.Netflix.adapter.view
{
    interface ViewPresenter
    {
        public void execute(Output output);
    }
}
