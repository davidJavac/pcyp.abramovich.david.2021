using Clase3.Ejercicio4.Netflix.adapter.view.implementation;
using Clase3.Ejercicio4.Netflix.core.entity;
using Clase3.Ejercicio4.Netflix.usecase.dto;
using Clase3.Ejercicio4.Netflix.util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase3.Ejercicio4.Netflix.adapter.view.implementation
{
    public class ConsoleNetflixRatingView : ViewPresenter
    {
        public void execute(Output output)
        {
            OutputNetflixRatingDto presenterDto = (OutputNetflixRatingDto)output;

            Dictionary<int, int> response = (Dictionary<int, int>)presenterDto.getResponse();

            Console.WriteLine("Response status: " + presenterDto.getResponseStatus());
            Console.WriteLine("Message: " + presenterDto.getMessage());

            foreach (KeyValuePair<int, int> item in response.OrderByDescending(key => key.Value).Take(10))
            {
                Console.WriteLine(item.Key + ":" + item.Value);
               
            }
        }

    }
}
