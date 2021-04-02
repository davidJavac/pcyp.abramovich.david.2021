using Clase3.Ejercicio3.WordCount.interface_adapter.view;
using Clase3.Ejercicio3.WordCount.usecase.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio3.WordsCount.interface_adapter.view.implementation
{
    class ConsoleWordCount : CollectionPresenter
    {
        public void present(Output output)
        {
            Dictionary<String, int> response = (Dictionary<String, int>)output.getResponse();

            Console.WriteLine("Response message: " + output.Message);

            foreach (KeyValuePair<String, int> entry in response) {

                Console.WriteLine(entry.Key + " " + entry.Value);
            }
            Console.WriteLine("size: " + response.Count);
        }
    }
}
