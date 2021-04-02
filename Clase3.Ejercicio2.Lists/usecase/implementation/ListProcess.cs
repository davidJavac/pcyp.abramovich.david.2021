using Clase3.Ejercicio2.Lists.usecase.dto;
using Clase3.Ejercicio2.Lists.usecase.dto.implementation;
using Clase3.Ejercicio2.Lists.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2.Lists.usecase.implementation
{
    class ListProcess : CollectionProcess
    {
        public Output execute(Input input)
        {
            InputAdapterDto inputAdapter = (InputAdapterDto)input;
            List<List<String>> listString = (List<List<String>>)inputAdapter.getValue();

            if (inputAdapter.getOperation().Equals(ApplicationConstants.Operation.COMPLETED_LIST))
            {
                return new OutputListDto(listString[0], "printing completed list");
            }
            else {
                List<String> removedList = getRemovedList(listString[0], listString[1]);
                return new OutputListDto(removedList, "printing removed list");
            }
            
        }

        private List<String> getRemovedList(List<String> listToRemove, List<String> valuesToRemove) {

            List<String> copylist = getCopyList(listToRemove);

            foreach (String s in copylist) {

                if (valuesToRemove.Contains(s)) {
                    listToRemove.Remove(s);
                }
            }

            return listToRemove;
        }

        private List<String> getCopyList(List<String> list) {
            List<String> copylist = new List<String>();

            list.ForEach(color =>
            {
                copylist.Add(color);
            });
            return copylist;
        }
    }
}
