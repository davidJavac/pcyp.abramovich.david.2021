using Clase1Ejercicio2Vial.usecase.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio2Vial.adapter.view
{
    interface ViewPresenter<Out>
    {
        public void execute(Out output);
    }
}
