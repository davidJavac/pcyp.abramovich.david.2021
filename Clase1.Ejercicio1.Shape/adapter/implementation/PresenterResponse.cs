
using Clase1Ejercicio1Shape.adapter.view;
using Clase1Ejercicio1Shape.adapter.view.implementation;
using Clase1Ejercicio1Shape.usecase.dto;

namespace Clase1Ejercicio1Shape.adapter.implementation
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
