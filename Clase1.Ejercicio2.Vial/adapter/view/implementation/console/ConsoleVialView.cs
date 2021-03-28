using Clase1.Ejercicio2.Vial.adapter.view.implementation;
using Clase1.Ejercicio2.Vial.core.usecase.dto;
using Clase1Ejercicio2Vial.core.entity;
using Clase1Ejercicio2Vial.usecase.dto;
using Clase1Ejercicio2Vial.util;
using System;
using System.Collections.Generic;

namespace Clase1Ejercicio2Vial.adapter.view.implementation
{
    public class ConsoleVialView : ViewPresenter<OutputVialDto>
    {
        private static int numPage = 0;

        public void execute(OutputVialDto output)
        {
            HeaderVialDto header = (HeaderVialDto)output.AdditionalInformation[ApplicationConstants.DtoKey.HEADER];
            List<VialDto> listResponse = (List<VialDto>)output.getResponse();
            Console.Clear();

            printResponseStatus(output);

            numPage++;

            printResponseHeader(header);

            printResponseRows(output);

            evaluateToContinue();
        }

        private void printResponseStatus(OutputVialDto output) {
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("Response of the process");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Status: " + output.getResponseStatus());
            Console.WriteLine("Message: " + output.getMessage() + "\n");
        }

        private void printResponseHeader(HeaderVialDto header) {

            Console.WriteLine("pag - " + numPage + "\n");
            ConsoleTable.PrintLine();
            ConsoleTable.PrintRow(header.N_sheet, header.Object_type,
                header.Id_section, header.Path_type, header.Lenght);
            ConsoleTable.PrintLine();
        }

        private void printResponseRows(OutputVialDto output) {
            List<VialDto> list = (List<VialDto>)output.getResponse();

            foreach (VialDto vial in list)
            {

                ConsoleTable.PrintRow(vial.N_sheet.ToString(), vial.ObjectType,
                    vial.IdSection.ToString(), vial.PathType, vial.Lenght.ToString());
                ConsoleTable.PrintLine();
            }
        }

        private void evaluateToContinue() {
            Console.WriteLine("\nPress any key to continue, 'e' letter to exit");
            String key = Console.ReadLine();
            if (key.Trim().Equals("e")) Environment.Exit(0);
        }

    }
}
