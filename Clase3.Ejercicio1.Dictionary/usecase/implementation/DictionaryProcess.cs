using Clase3.Ejercicio1.Dictionary.interface_adapter.view;
using Clase3.Ejercicio1.Dictionary.interface_adapter.view.implementation;
using Clase3.Ejercicio1.Dictionary.usecase.dto;
using Clase3.Ejercicio1.Dictionary.usecase.dto.implementation;
using Clase3.Ejercicio1.Dictionary.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1.Dictionary.usecase.implementation
{
    class DictionaryProcess : CollectionProcess
    {
        private Dictionary<String, String> dictionary;
        private InputDictionary inputDictionary;
        private String operation;
        public Output execute(Input input)
        {
            inputDictionary = (InputDictionary)input;
            dictionary = (Dictionary<String, String>)inputDictionary.getValue();

            operation = (String)inputDictionary
                .AdditionalInformation[ApplicationConstants.Operation.OPERATION];

            return performOperation();
        }

        private Output performOperation() { 
            
            if (operation.Equals(ApplicationConstants.Operation.CONTAINS_NAME))
            {
                String name = (String)inputDictionary
                    .AdditionalInformation[ApplicationConstants.ContainsName.NAME];
                return evaluateResponseByName(name);
            }
            else if (operation.Equals(ApplicationConstants.Operation.ITERATE))
            {
                return getOutputWithAllDictionary();
            }
            else
            {
                return getOutputWithChangedValue();
            }
        
        }

        private Output evaluateResponseByName(String name) { 
        
            if (dictionary.ContainsKey(name))
            {
                return getOutputIfContainsName(name);
            }
            else {
                return getOutputIfNotContainsName(name);
            }
        
        }

        private Output getOutputIfContainsName(String name) {

            String key = name;
            String value;
            dictionary.TryGetValue(key, out value);
            return new OutputDictionary(value, operation);

        }

        private Output getOutputIfNotContainsName(String name) {
            return new OutputDictionary("it does not contain the name ", operation);
        }

        private Output getOutputWithChangedValue() {
            
            String key = (String)inputDictionary
                .AdditionalInformation[ApplicationConstants.ChangeValue.KEY];
            dictionary[key] = "58251425";
            String newValue;
            dictionary.TryGetValue(key, out newValue);
            String response = "the new value of " + key + " is " + newValue;

            return new OutputDictionary(response, operation);
        }

        private Output getOutputWithAllDictionary() {
            
            String response = "";
            int cont = 1;
            foreach (KeyValuePair<string, string> entry in dictionary) {

                response += entry.Key + ": " + entry.Value;
                response += cont < dictionary.Count ? "\n" : "";
                cont++;
            }
            return new OutputDictionary(response, operation);
        }
    }
}
