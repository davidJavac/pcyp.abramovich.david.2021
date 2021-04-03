using Clase3.Ejercicio4.Netflix.adapter.view;
using Clase3.Ejercicio4.Netflix.adapter.view.implementation;
using Clase3.Ejercicio4.Netflix.core.entity;
using Clase3.Ejercicio4.Netflix.usecase.dto;
using Clase3.Ejercicio4.Netflix.util;
using System.Collections.Generic;
using System.Linq;

namespace Clase3.Ejercicio4.Netflix.adapter.implementation
{
    class PresenterNetflixResponse : ManageOutput
    {
        private OutputNetflixRatingDto outputNetflixRatingDto;
        private ViewPresenter consoleNetflixRatingView;

        public void execute(Output output)
        {
            consoleNetflixRatingView = new ConsoleNetflixRatingView();

            outputNetflixRatingDto = (OutputNetflixRatingDto)output;

            consoleNetflixRatingView.execute(outputNetflixRatingDto);
        }

    }
}
