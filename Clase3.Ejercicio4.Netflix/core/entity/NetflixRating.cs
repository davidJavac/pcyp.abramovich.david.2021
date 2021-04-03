using System;

namespace Clase3.Ejercicio4.Netflix.core.entity
{
    public class NetflixRating
    {
        private int idMovie;
        private int idUser;
        private int rating;
        private String date;
        public NetflixRating(int idMovie, int idUser, int rating, String date) {
            this.IdMovie = idMovie;
            this.IdUser = idUser;
            this.Rating = rating;
            this.Date = date;
        }
        public int IdMovie { get => idMovie; set => idMovie = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public int Rating { get => rating; set => rating = value; }
        public string Date { get => date; set => date = value; }
    }
}
