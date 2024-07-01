using Microsoft.EntityFrameworkCore;
using TPdeEFCore01.Datos.Interfaces;
using TPdeEFCore01.Entidades;

namespace TPdeEFCore01.Datos.Repositorios
{
    public class SportRepositorio : ISportsRepositorio
    {
        private readonly ShoesDbContext _dbContext;
        public SportRepositorio(ShoesDbContext dbContext)
        {
            _dbContext = dbContext;    
        }

        public void Agregar(Sport Sport)
        {
            _dbContext.Sports.Add(Sport);
        }

        public void Borrar(Sport Sport)
        {
            _dbContext.Sports.Remove(Sport);
        }

        public void Editar(Sport Sport)
        {
            _dbContext.Sports.Update(Sport);
        }

        public bool EstaRelacionado(Sport Sport)
        {
            return _dbContext.shoes.Any(s => s.SportId == Sport.SportId);
        }

        public bool Existe(Sport Sport)
        {
            if (Sport.SportId == 0)
            {
                return _dbContext.Sports.Any(s => s.SportName == Sport.SportName);
            }
            return _dbContext.Sports.Any(s => s.SportName == Sport.SportName &&
            s.SportId != Sport.SportId);
        }

        public int GetCantidad()
        {
            return _dbContext.Sports.Count();
        }

        public List<Sport> GetLista()
        {
            return _dbContext.Sports
                 .OrderBy(s=>s.SportId)
                .ToList();
        }

        public List<Sport>? GetListaPaginada(int paginaActual, int cantidadPorPagina)
        {
            IQueryable<Sport> query = _dbContext.Sports.OrderBy(s=>s.SportId)
               .Select(s => new Sport
               {
                   SportId = s.SportId,
                   SportName = s.SportName
               });

            return query.Skip((paginaActual) * cantidadPorPagina)
                             .Take(cantidadPorPagina)
                             .ToList();

        }

        public Sport? GetSportId(int SportId)
        {
            return _dbContext.Sports.SingleOrDefault(s => s.SportId == SportId);

        }

        public Sport? GetSportPorNombre(string nuevaDescripcion)
        {
            return _dbContext.Sports.SingleOrDefault(s => s.SportName == nuevaDescripcion);

        }

        public List<Shoe>? GetSports(Sport? sport)
        {
            var lista = _dbContext.shoes
               .Include(b => b.brand)
               .Include(b => b.genre)
               .Include(b => b.sport)
               .Include(b => b.color)
               .Where(shoe => shoe.SportId == sport.SportId).ToList();
            return lista;
        }
    }
}
