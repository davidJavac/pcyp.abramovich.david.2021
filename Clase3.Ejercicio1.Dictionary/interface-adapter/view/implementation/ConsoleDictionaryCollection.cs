using Clase3.Ejercicio1.Dictionary.usecase.dto;
using Clase3.Ejercicio1.Dictionary.usecase.dto.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1.Dictionary.interface_adapter.view.implementation
{
    class ConsoleDictionaryCollection : CollectionPresenter
    {
        public void present(Output output)
        {
            OutputDictionary outputDictionary = (OutputDictionary)output;

            String response = (String)outputDictionary.getResponse();

            Console.WriteLine("Operation: " + outputDictionary.Operation);
            Console.WriteLine(response + "\n");
        }
    }
}
