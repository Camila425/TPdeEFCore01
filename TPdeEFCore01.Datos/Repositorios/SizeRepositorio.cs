using Microsoft.EntityFrameworkCore;
using TPdeEFCore01.Datos.Interfaces;
using TPdeEFCore01.Entidades;
using TPdeEFCore01.Entidades.Enums;

namespace TPdeEFCore01.Datos.Repositorios
{
    public class SizeRepositorio : ISizeRepositorio
    {
        private readonly ShoesDbContext _dbContext;

        public SizeRepositorio(ShoesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Agregar(Size talle)
        {
            _dbContext.Sizes.Add(talle);
        }

        public void Borrar(Size size)
        {
            _dbContext.Sizes.Remove(size);
        }

        public void Editar(Size talle)
        {
            _dbContext.Sizes.Update(talle);
        }

        public bool EstaRelacionado(Size size)
        {
            return _dbContext.shoeSizes.Any(s => s.SizeId == size.SizeId);
        }

        public bool Existe(Size talle)
        {
            if (talle.SizeId == 0)
            {
                return _dbContext.Sizes.Any(s => s.SizeNumber == talle.SizeNumber);
            }
            return _dbContext.Sizes.Any(s => s.SizeNumber == talle.SizeNumber &&
            s.SizeId != talle.SizeId);
        }

        public int GetCantidad()
        {
            return _dbContext.Sizes.Count();
        }

        public List<Size> GetLista()
        {
            return _dbContext.Sizes
                 .OrderBy(s => s.SizeId)
                .ToList();
        }

        public List<Size>? GetListaOrdenadaPorTalle(int paginaActual, int cantidadPorPagina, Orden? orden = null)
        {
            IQueryable<Size> query =
                _dbContext.Sizes
                .AsNoTracking();

            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.MenorTalle:
                        query = query.OrderBy(s => s.SizeNumber);
                        break;
                    case Orden.MayorTalle:
                        query = query.OrderByDescending(s => s.SizeNumber);
                        break;
                }
            }

            List<Size> listaPaginada = query
                .Skip(paginaActual * cantidadPorPagina)
                .Take(cantidadPorPagina)
                .ToList();

            return listaPaginada;
        }

        public List<Size>? GetListaPaginada(int pagina, int cantidadPorPagina, Orden? orden = null)
        {
            IQueryable<Size> query = _dbContext.Sizes.AsNoTracking();

            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.MenorTalle:
                        query = query.OrderBy(s => s.SizeNumber);
                        break;
                    case Orden.MayorTalle:
                        query = query.OrderByDescending(s => s.SizeNumber);
                        break;
                    default:
                        break;
                }
            }

            List<Size> listaPaginada = query
                .Skip(pagina * cantidadPorPagina)
                .Take(cantidadPorPagina)
                .ToList();

            return listaPaginada;
        }

        public Size? GetSizeId(int talleIdInt, bool incluyeZapatos)
        {
            var query = _dbContext.Sizes;
            if (incluyeZapatos)
            {
                return query.Include(s => s.shoeSizes).ThenInclude(ss => ss.shoe)
                            .FirstOrDefault(s => s.SizeId == talleIdInt);
            }
            return query.FirstOrDefault(s => s.SizeId == talleIdInt);
        }
    }
}
