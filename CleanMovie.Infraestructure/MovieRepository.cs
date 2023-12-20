using CleanMovie.Application;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infraestructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie{Id = 1, Name="Interestelar", Cost = 1},
            new Movie{Id = 2, Name="Ciudad de Dios", Cost = 3}
        };



        public List<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}
