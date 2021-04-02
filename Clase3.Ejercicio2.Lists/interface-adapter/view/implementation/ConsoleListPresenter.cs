using Clase3.Ejercicio2.Lists.usecase.dto;
using Clase3.Ejercicio2.Lists.usecase.dto.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2.Lists.interface_adapter.view.implementation
{
    class ConsoleListPresenter : CollectionPresenter
    {
        public void present(Output output)
        {
            OutputListDto outputListDto = (OutputListDto)output;
            Console.Write("Response:");
            Console.WriteLine("\nOperation: " + outputListDto.getOperation());
            List<String> response = (List<String>)outputListDto.getResponse();
            
            response.ForEach(element =>
            {
                Console.Write(element + " ");
            });
        }
    }
}
