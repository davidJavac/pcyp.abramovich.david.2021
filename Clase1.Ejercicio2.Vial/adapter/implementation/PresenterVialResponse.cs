using Clase1.Ejercicio2.Vial.core.usecase.dto;
using Clase1Ejercicio2Vial.adapter.view;
using Clase1Ejercicio2Vial.adapter.view.implementation;
using Clase1Ejercicio2Vial.core.entity;
using Clase1Ejercicio2Vial.usecase.dto;
using Clase1Ejercicio2Vial.util;
using System.Collections.Generic;

namespace Clase1Ejercicio2Vial.adapter.implementation
{
    class PresenterVialResponse : ManageOutput
    {
        private OutputVialDto outputVialDto;
        private ViewPresenter<OutputVialDto> consoleVialView;

        public void execute(Output output)
        {  
            consoleVialView = new ConsoleVialView();

            outputVialDto = (OutputVialDto)output;

            evaluateResponseStatus();
        }

        private void evaluateResponseStatus() {

            if (outputVialDto.getResponseStatus().Equals(ApplicationConstants.Status.SUCCESS))
            {
                paginateWithIntervalsOf(8);
            }
            else {
                outputVialDto.AdditionalInformation.Add(ApplicationConstants.DtoKey.HEADER, 
                    new HeaderVialDto());
                consoleVialView.execute(outputVialDto);
            }
        }

        private void paginateWithIntervalsOf(int interval) { 
            
            List<VialDto> listVialDto = (List<VialDto>)outputVialDto.getResponse();
        
            int rows = listVialDto.Count;
            int paginatedRows = 0;
            int intervalCount = 0;

            while (rows > 0) {

                int start = paginatedRows;

                OutputVialDto output = getOutputVialDtoWithSubListOfVialDto(start, interval, listVialDto);

                consoleVialView.execute(output);

                if (rows >= interval)
                {
                    rows -= interval;

                    intervalCount++;
                    paginatedRows = interval * intervalCount;

                    if (rows < interval) {
                        interval = rows;
                    }
                }
                
            }
        
        }


        private OutputVialDto getOutputVialDtoWithSubListOfVialDto(int start, int interval, 
            List<VialDto> listVialDto) {

            List<VialDto> subList = listVialDto.GetRange(start, interval);
            OutputVialDto output = new OutputVialDto(subList, outputVialDto.getResponseStatus(),
                outputVialDto.getMessage());
            output.AdditionalInformation.Add(ApplicationConstants.DtoKey.HEADER, new HeaderVialDto());

            return output;
        }
    }
}
