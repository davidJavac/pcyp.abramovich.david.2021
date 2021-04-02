using Clase3.Ejercicio3.WordCount.usecase;
using Clase3.Ejercicio3.WordCount.usecase.dto;
using Clase3.Ejercicio3.WordsCount.usecase.dto.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio3.WordsCount.usecase.implementation
{
    class WordCountProcess : CollectionProcess
    {
        public Output execute(Input input)
        {
            List<String> words = (List<String>)input.getValue();

            Dictionary<String, int> wordsOcurrences = convertListToDictionary(words);

            OutputDto output =  new OutputDto(wordsOcurrences);
            output.Message = "successful response";

            return output;
        }

        private Dictionary<String, int> convertListToDictionary(List<String> words) {

            Dictionary<String, int> wordsOcurrences = new Dictionary<String, int>();
            
            words.ForEach(word =>
            {
                if (!wordsOcurrences.ContainsKey(word))
                {
                    wordsOcurrences.Add(word, 1);
                }
                else {
                    int cont;
                    wordsOcurrences.TryGetValue(word, out cont);
                    wordsOcurrences[word] = cont + 1;
                }
            });

            return wordsOcurrences;
        }
    }
}
