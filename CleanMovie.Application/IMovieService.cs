using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public interface IMovieService
    {
        // Es un caso de uso
        List<Movie> GetAllMovies();
    }
}
