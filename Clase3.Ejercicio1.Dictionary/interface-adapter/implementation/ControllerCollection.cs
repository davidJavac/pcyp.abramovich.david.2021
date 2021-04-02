using Clase3.Ejercicio1.Dictionary.interface_adapter.view;
using Clase3.Ejercicio1.Dictionary.usecase;
using Clase3.Ejercicio1.Dictionary.usecase.dto;
using Clase3.Ejercicio1.Dictionary.usecase.dto.implementation;
using Clase3.Ejercicio1.Dictionary.usecase.implementation;
using Clase3.Ejercicio1.Dictionary.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1.Dictionary.interface_adapter.implementation
{
    class ControllerCollection : ManageCollection
    {
        private CollectionPresenter presenter;
        private CollectionProcess process;

        public ControllerCollection(CollectionPresenter presenter, CollectionProcess process) {
            this.presenter = presenter;
            this.process = process;
        }

        public void execute(Input input)
        {
            //InputDictionary inputDictionary = (InputDictionary)input;

            input.AdditionalInformation.Add(ApplicationConstants.Operation.OPERATION, 
                ApplicationConstants.Operation.CONTAINS_NAME);

            addNameToInput("Juan", input);

            processAndPresent(input);

            changeNameToInput("Pedro", input);

            processAndPresent(input);

            changeOperationToIterateAll(input);

            processAndPresent(input);

            changeOperationToChangeValue(input, "Mariana");
            
            processAndPresent(input);
        }

        public void processAndPresent(Input input) { 
        
            Output outputNotContainsName = process.execute(input);

            presenter.present(outputNotContainsName);
        }

        private void addNameToInput(String name, Input input) { 
        
            input.AdditionalInformation.Add(ApplicationConstants.ContainsName.NAME,
                name);
        }

        private void changeNameToInput(String name, Input input) {
            input.AdditionalInformation[ApplicationConstants.ContainsName.NAME] = name;
        }

        private void changeOperationToIterateAll(Input input) {
            input.AdditionalInformation[ApplicationConstants.Operation.OPERATION] = 
                ApplicationConstants.Operation.ITERATE;
        }

        private void changeOperationToChangeValue(Input input, String key)
        {
            input.AdditionalInformation[ApplicationConstants.Operation.OPERATION] =
                ApplicationConstants.Operation.CHANGE_VALUE;
            input.AdditionalInformation.Add(ApplicationConstants.ChangeValue.KEY, key);
        }
    }
}
