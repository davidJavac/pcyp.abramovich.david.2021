using Clase3.Ejercicio1.Dictionary.interface_adapter;
using Clase3.Ejercicio1.Dictionary.interface_adapter.implementation;
using Clase3.Ejercicio1.Dictionary.interface_adapter.view;
using Clase3.Ejercicio1.Dictionary.interface_adapter.view.implementation;
using Clase3.Ejercicio1.Dictionary.usecase;
using Clase3.Ejercicio1.Dictionary.usecase.dto.implementation;
using Clase3.Ejercicio1.Dictionary.usecase.implementation;
using System;
using System.Collections.Generic;

namespace Clase3.Ejercicio1.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> dictionary = new Dictionary<String, String>();
            dictionary.Add("Juan", "55423412");
            dictionary.Add("Ernesto", "56985623");
            dictionary.Add("Mariana", "54787451");
            
            CollectionProcess process = new DictionaryProcess();
            CollectionPresenter presenter = new ConsoleDictionaryCollection();

            ManageCollection manageCollection = new ControllerCollection(presenter, process);
            manageCollection.execute(new InputDictionary(dictionary));
        }
    }
}
