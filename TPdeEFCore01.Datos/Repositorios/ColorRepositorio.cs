using TPdeEFCore01.Datos.Interfaces;
using TPdeEFCore01.Entidades;

namespace TPdeEFCore01.Datos.Repositorios
{
    public class ColorRepositorio : IColorsRepositorio
    {
        private readonly ShoesDbContext _dbContext;
        public ColorRepositorio(ShoesDbContext dbContext)
        {
            _dbContext = dbContext;    
        }
        public void Agregar(Color Color)
        {
            _dbContext.Colors.Add(Color);
        }

        public void Borrar(Color Color)
        {
            _dbContext.Colors.Remove(Color);
        }

        public void Editar(Color Color)
        {
            _dbContext.Colors.Update(Color);
        }

        public bool EstaRelacionado(Color Color)
        {
            return _dbContext.shoes.Any(c => c.ColorId == Color.ColorId);
        }

        public bool Existe(Color Color)
        {
            if (Color.ColorId == 0)
            {
                return _dbContext.Colors.Any(c => c.ColorName == Color.ColorName);
            }
            return _dbContext.Colors.Any(c => c.ColorName == Color.ColorName &&
            c.ColorId != Color.ColorId);
        }

        public int GetCantidad()
        {
            return _dbContext.Colors.Count();
        }

        public Color? GetColorId(int ColorId)
        {
            return _dbContext.Colors.SingleOrDefault(c => c.ColorId ==ColorId);
        }

        public Color? GetColorPorNombre(string nuevaDescripcion)
        {
            return _dbContext.Colors.SingleOrDefault(c=> c.ColorName == nuevaDescripcion);
        }

        public List<Color> GetLista()
        {
            return _dbContext.Colors
                  .OrderBy(c => c.ColorId)
                 .ToList();
        }

        public List<Color>? GetListaPaginada(int paginaActual, int cantidadPorPagina)
        {
            IQueryable<Color> query = _dbContext.Colors.OrderBy(c=>c.ColorId)
               .Select(c => new Color
               {
                   ColorId = c.ColorId,
                   ColorName = c.ColorName
               });

            return query.Skip((paginaActual) * cantidadPorPagina)
                             .Take(cantidadPorPagina)
                             .ToList();
        }
    }
}
