using Clase3.Ejercicio2.Lists.interface_adapter.view;
using Clase3.Ejercicio2.Lists.interface_adapter.view.implementation;
using Clase3.Ejercicio2.Lists.usecase;
using Clase3.Ejercicio2.Lists.usecase.dto;
using Clase3.Ejercicio2.Lists.usecase.dto.implementation;
using Clase3.Ejercicio2.Lists.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2.Lists.interface_adapter.implementation
{
    class ControllerCollection : ManageCollection
    {
        private CollectionProcess process;
        private CollectionPresenter presenter;
        private InputAdapterDto inputAdapter;
        public ControllerCollection(CollectionProcess process) {
            this.process = process;
        }
        public void execute(InputDto input)
        {
            presenter = new ConsoleListPresenter();

            inputAdapter = new InputAdapterDto();

            String[] colors = input.Colors;
            String[] removeColors = input.Removecolors;

            List<String> listColors = convertToList(colors);
            List<String> listRemoveColors = convertToList(removeColors);

            addAdaptedListsToInputAdapter(inputAdapter, listColors, listRemoveColors);

            performOperation(ApplicationConstants.Operation.COMPLETED_LIST);
            performOperation(ApplicationConstants.Operation.REMOVED_LIST);

        }

        private List<String> convertToList(String[] values) {

            List<String> list = new List<String>();

            for (int i = 0; i < values.Length; i++) {

                list.Add(values[i]);
            }
            return list;
        }

        private void addAdaptedListsToInputAdapter(InputAdapterDto input, List<String> listColors, 
            List<String> listRemovedColors) { 
            
            List<List<String>> listAdapter = new List<List<String>>();
            listAdapter.Add(listColors);
            listAdapter.Add(listRemovedColors);

            input.setValue(listAdapter);
        }

        public void performOperation(String operation) {
            inputAdapter.setOperation(operation);
            Output output = process.execute(inputAdapter);

            presenter.present(output);
        }
    }
}
