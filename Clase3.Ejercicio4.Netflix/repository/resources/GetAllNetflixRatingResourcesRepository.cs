using Clase3.Ejercicio4.Netflix.core.repository;
using Clase3.Ejercicio4.Netflix.core.entity;
using Clase3.Ejercicio4.Netflix.repository.exception;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Clase3.Ejercicio4.Netflix.repository
{
    public class GetAllNetflixRatingResourcesRepository : GetAllNetflixRatingRepository
    {
        public List<NetflixRating> execute(String path)
        {
            ConcurrentQueue<NetflixRating> threadSafeCollection = new ConcurrentQueue<NetflixRating>();

            try
            {
                Parallel.ForEach(File.ReadLines(path), (line, _, lineNumber) =>
                {
                    addNetflixRatingToSafeCollection(threadSafeCollection, line);
                });
            }
            catch (Exception e) {
                throw new RepositoryException(e.Message);
            }

            return fromConcurrentQueueToListVialDto(threadSafeCollection);
        }

        public void addNetflixRatingToSafeCollection(ConcurrentQueue<NetflixRating> threadSafeCollection, String line) { 
   
            String[] fields = line.Split(",");

            int idMovie = Int32.Parse(fields[0]);
            int idUser = Int32.Parse(fields[1]);
            int rating = Int32.Parse(fields[2]);
            String date = fields[3];
                    
            NetflixRating netflixRating = new NetflixRating(idMovie, idUser, rating, date);

            threadSafeCollection.Enqueue(netflixRating);
   
        }

        private List<core.entity.NetflixRating> fromConcurrentQueueToListVialDto(ConcurrentQueue<core.entity.NetflixRating> queue) {

            List<core.entity.NetflixRating> listVialDto = new List<core.entity.NetflixRating>();

            while (!queue.IsEmpty) {
                core.entity.NetflixRating vialDto;
                queue.TryDequeue(out vialDto);
                listVialDto.Add(vialDto);
            }

            return listVialDto;
        
        }
    }
}
