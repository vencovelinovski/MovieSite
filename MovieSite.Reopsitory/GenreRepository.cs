using MovieSite.Data;
using MovieSite.Entities;
using MovieSite.Reopsitory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieSite.Reopsitory
{
    public class GenreRepository : IGenreRepository
    {
        private readonly DataContext _context;
        public void AddGenre(Genre genre)
        {
            _context.Genre.Add(genre);
            _context.SaveChanges();
        }

        public void DeleteGenre(int genreId)
        {
            Genre genre = GetGenreById(genreId);
            _context.Genre.Remove(genre);
            _context.SaveChanges();
        }

        private Genre GetGenreById(int genreId)
        {
            
                var result = _context.Genre.FirstOrDefault(x => x.Id == id);
                return result;
            
        }
    }

    public void EditGenre(Genre genre)
        {
            _context.Genre.Update(genre);
        }


    public IEnumerable<Genre> GetAllGenres()
        {
                var result = _context.Genre.AsEnumerable();
                return result;
            }
        }

   
}
