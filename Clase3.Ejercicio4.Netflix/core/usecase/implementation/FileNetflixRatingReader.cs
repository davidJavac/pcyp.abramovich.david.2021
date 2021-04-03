using Clase3.Ejercicio4.Netflix.core.repository;
using Clase3.Ejercicio4.Netflix.config;
using Clase3.Ejercicio4.Netflix.core.entity;
using Clase3.Ejercicio4.Netflix.usecase.dto;
using Clase3.Ejercicio4.Netflix.usecase.validation;
using Clase3.Ejercicio4.Netflix.util;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Clase3.Ejercicio4.Netflix.usecase.implementation
{
    public class FileNetflixRatingReader : Interactor
    {
        private InputAdapterDto input;
        private GetAllNetflixRatingRepository getAllNetflixRatingRepository;

        public Output execute(InputAdapterDto input)
        {
            try
            {
                this.input = input;

                getAllNetflixRatingRepository = createGetAllNetflixRatingRepository();

                List<NetflixRating> listNetflixRating = getAllNetflixRatingRepository.execute(input.Path);

                Dictionary<int, int> userMoreRatings = prepareUserWithRating(listNetflixRating);

                return prepareSuccessfullResponse(userMoreRatings);

            }
            catch (Exception e) {

                return prepareErrorResponse(e.Message);
            }
            
        }

        private OutputNetflixRatingDto prepareSuccessfullResponse(Dictionary<int, int> response) {
            return new OutputNetflixRatingDto(response,
                ApplicationConstants.Status.SUCCESS,
                "Operation ran successfully");
            
        }
        private OutputNetflixRatingDto prepareErrorResponse(string message)
        {
            return new OutputNetflixRatingDto(null,
                ApplicationConstants.Status.ERROR,
                message);
            
        }

        private Dictionary<int, int> prepareUserWithRating(List<NetflixRating> listNetflixRating) {
            ConcurrentDictionary<int, int> threadSafeCollection = new ConcurrentDictionary<int, int>();

            Parallel.ForEach(listNetflixRating, row =>
            {
                addRatingToSafeCollection(threadSafeCollection, row);
            });

            return new Dictionary<int, int>(threadSafeCollection);
        }

        private void addRatingToSafeCollection(ConcurrentDictionary<int, int> threadSafeCollection, NetflixRating row) {

            if (!threadSafeCollection.ContainsKey(row.IdUser))
            {
                threadSafeCollection.TryAdd(row.IdUser, 1);
            }
            else
            {
                int cont;
                threadSafeCollection.TryGetValue(row.IdUser, out cont);
                threadSafeCollection[row.IdUser] = cont + 1;
            }
        }

        private GetAllNetflixRatingRepository createGetAllNetflixRatingRepository() {
            return ModuleConfig.getAllNetflixRatingRepository();
        }

    }
}
