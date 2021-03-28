using Clase1.Ejercicio2.Vial.core.repository;
using Clase1Ejercicio2Vial.core.entity;
using Clase1Ejercicio2Vial.repository.exception;
using System;
using Clase1Ejercicio2Vial.core.entity;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Clase1.Ejercicio2.Vial.repository
{
    public class GetAllVialResourcesRepository : GetAllVialRepository
    {
        public List<VialDto> execute(String path)
        {
            ConcurrentQueue<VialDto> threadSafeCollection = new ConcurrentQueue<VialDto>();

            try
            {
                Parallel.ForEach(File.ReadLines(path), (line, _, lineNumber) =>
                {
                        String[] fields = line.Split(",");

                        int n_sheet = Int32.Parse(fields[0]);
                        String objectType = fields[1];
                        int idSection = Int32.Parse(fields[2]);
                        String pathType = fields[3];
                        int lenght = Int32.Parse(fields[4]);

                    VialDto vialDto = new VialDto(n_sheet, objectType, idSection, pathType, lenght);

                        threadSafeCollection.Enqueue(vialDto);
                               
                });
            }
            catch (Exception e) {
                throw new RepositoryException(e.Message);
            }

            return fromConcurrentQueueToListVialDto(threadSafeCollection);
        }

        private List<VialDto> fromConcurrentQueueToListVialDto(ConcurrentQueue<VialDto> queue) {

            List<VialDto> listVialDto = new List<VialDto>();

            while (!queue.IsEmpty) {
                VialDto vialDto;
                queue.TryDequeue(out vialDto);
                listVialDto.Add(vialDto);
            }

            return listVialDto;
        
        }
    }
}
