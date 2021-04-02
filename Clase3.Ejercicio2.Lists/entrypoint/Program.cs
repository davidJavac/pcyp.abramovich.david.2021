using Clase3.Ejercicio2.Lists.interface_adapter;
using Clase3.Ejercicio2.Lists.interface_adapter.implementation;
using Clase3.Ejercicio2.Lists.usecase;
using Clase3.Ejercicio2.Lists.usecase.dto.implementation;
using Clase3.Ejercicio2.Lists.usecase.implementation;
using System;

namespace Clase3.Ejercicio2.Lists
{
    class Program
    {
        private static readonly string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
        private static readonly string[] removeColors = { "RED", "WHITE", "BLUE" };
        static void Main(string[] args)
        {
            CollectionProcess process = new ListProcess();
            ManageCollection manage = new ControllerCollection(process);

            InputDto input = new InputDto();
            input.Colors = colors;
            input.Removecolors = removeColors;
            manage.execute(input);
        }
    }
}
