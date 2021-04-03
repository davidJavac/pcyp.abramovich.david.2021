using Clase3.Ejercicio3.WordCount.interface_adapter.view;
using Clase3.Ejercicio3.WordCount.usecase;
using Clase3.Ejercicio3.WordCount.usecase.dto;
using Clase3.Ejercicio3.WordsCount.usecase.dto.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio3.WordCount.interface_adapter.implementation
{
    class ControllerCollection : ManageCollection
    {
        private CollectionProcess process;
        private CollectionPresenter presenter;
        public ControllerCollection(CollectionProcess process, CollectionPresenter presenter) {
            this.process = process;
            this.presenter = presenter;
        }
        public void execute(Input input)
        {
            String text = (String)input.getValue();
            Input inputAdapter = new InputAdapterDto();

            List<String> listWords = convertTextToList(text);
            List<String> listWithoutEmpty = getListWithoutEmpty(listWords);
            inputAdapter.setValue(listWithoutEmpty);

            performResponse(inputAdapter);
        }

        private void performResponse(Input input) {
            
            List<String> words = (List<String>)input.getValue();
            if (words.Count == 0)
            {
                presentIfListIsEmpty();
            }
            else { 
           
                Output output = process.execute(input);

                presenter.present(output);
            }
        }

        private List<String> convertTextToList(String text) {

            String[] words = text.Split(" ");
            List<String> listWords = words.ToList<String>();
            return listWords;
        }

        private List<String> getListWithoutEmpty(List<String> words) {

            List<String> wordsWithoutEmpty = new List<String>();

            words.ForEach(word =>
            {
                if (!word.Equals(""))
                {
                    wordsWithoutEmpty.Add(word);
                }

            });

            return wordsWithoutEmpty;
        }
        private void presentIfListIsEmpty() {

            Output output = new OutputDto(new Dictionary<String, int>());
            output.Message = "you must enter words in the text";
            presenter.present(output);
        
        }
    }
}
