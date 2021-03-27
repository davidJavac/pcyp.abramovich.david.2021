using Clase1Ejercicio2Vial.adapter;
using Clase1Ejercicio2Vial.adapter.view;
using Clase1Ejercicio2Vial.adapter.view.implementation;
using Clase1Ejercicio2Vial.usecase.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio2Vial.adapter.implementation
{
    class PresenterResponse : ManageOutput
    {
        public void execute(OutputDto output)
        {
            ViewPresenter presenter = new ConsoleView();
            presenter.execute(output);
        }
    }
}
