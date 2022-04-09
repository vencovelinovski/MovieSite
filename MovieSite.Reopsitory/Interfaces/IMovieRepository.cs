using MovieSite.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSite.Reopsitory.Interfaces
{
  public  interface IMovieRepository
    {
        void AddMovie(Movie movie);

        void EditMovie(Movie movie);

        void DeleteMovie(int movieId);

        Movie GetActorById(int id);

        IEnumerable<Movie> GetAllMovies();
    }
}
