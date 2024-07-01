using Microsoft.EntityFrameworkCore;
using TPdeEFCore01.Datos.Interfaces;
using TPdeEFCore01.Entidades;

namespace TPdeEFCore01.Datos.Repositorios
{
    public class GenreRepositorio : IGenresRepositorio
    {
        private readonly ShoesDbContext _dbContext;
        public GenreRepositorio(ShoesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Agregar(Genre Genre)
        {
            _dbContext.Genres.Add(Genre);
        }

        public void Borrar(Genre Genre)
        {
            _dbContext.Genres.Remove(Genre);
        }

        public void Editar(Genre Genre)
        {
            _dbContext.Genres.Update(Genre);
        }

        public bool EstaRelacionado(Genre Genre)
        {
            return _dbContext.shoes.Any(g => g.BrandId == Genre.GenreId);
        }

        public bool Existe(Genre Genre)
        {
            if (Genre.GenreId == 0)
            {
                return _dbContext.Genres.Any(g => g.GenreName == Genre.GenreName);
            }
            return _dbContext.Genres.Any(g => g.GenreName == Genre.GenreName &&
            g.GenreId != Genre.GenreId);
        }

        public List<Shoe>? GetGenres(Genre? genre)
        {
            var lista = _dbContext.shoes
               .Include(b => b.brand)
               .Include(b => b.genre)
               .Include(b => b.sport)
               .Include(b => b.color)
               .Where(shoe => shoe.GenreId == genre.GenreId).ToList();
            return lista;
        }

        public int GetCantidad()
        {
            return _dbContext.Genres.Count();
        }

        public Genre? GetGenreId(int GenreId)
        {
            return _dbContext.Genres.SingleOrDefault(g => g.GenreId == GenreId);
        }

        public Genre? GetGenrePorNombre(string nuevaDescripcion)
        {
            return _dbContext.Genres.SingleOrDefault(g => g.GenreName == nuevaDescripcion);
        }

        public List<Genre> GetLista()
        {
            return _dbContext.Genres
                .OrderBy(g => g.GenreId)
                .ToList();
        }

        public List<Genre>? GetListaPaginada(int paginaActual, int cantidadPorPagina)
        {
            IQueryable<Genre> query = _dbContext.Genres.OrderBy(g => g.GenreId)
               .Select(g => new Genre
               {
                   GenreId = g.GenreId,
                   GenreName = g.GenreName
               });

            return query.Skip((paginaActual) * cantidadPorPagina)
                             .Take(cantidadPorPagina)
                             .ToList();
        }

        public List<Shoe>? GetGenreySport(Genre? genre, Sport? sport)
        {
            var lista = _dbContext.shoes
           .Include(b => b.brand)
           .Include(b => b.genre)
           .Include(b => b.sport)
           .Include(b => b.color)
            .Where(shoe => shoe.GenreId == genre.GenreId && shoe.SportId == sport.SportId)
            .ToList();
            return lista;
        }
    }
}
