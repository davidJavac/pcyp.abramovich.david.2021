
using Clase3.Ejercicio4.Netflix.core.entity;
using System.Collections.Generic;

namespace Clase3.Ejercicio4.Netflix.core.repository
{
    public interface GetAllNetflixRatingRepository
    {
        public List<NetflixRating> execute(string path);
    }
}
