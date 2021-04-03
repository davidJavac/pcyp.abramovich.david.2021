using Clase3.Ejercicio3.WordCount.interface_adapter;
using Clase3.Ejercicio3.WordCount.interface_adapter.implementation;
using Clase3.Ejercicio3.WordCount.interface_adapter.view;
using Clase3.Ejercicio3.WordCount.usecase;
using Clase3.Ejercicio3.WordCount.usecase.dto;
using Clase3.Ejercicio3.WordsCount.interface_adapter.dto;
using Clase3.Ejercicio3.WordsCount.interface_adapter.view.implementation;
using Clase3.Ejercicio3.WordsCount.usecase.implementation;
using System;

namespace Clase3.Ejercicio3.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a text:");
            String text = Console.ReadLine();
            Input input = new InputDto();
            input.setValue(text);

            CollectionProcess process = new WordCountProcess();
            CollectionPresenter presenter = new ConsoleWordCount();
            ManageCollection manage = new ControllerCollection(process, presenter);

            manage.execute(input);
        }
    }
}
