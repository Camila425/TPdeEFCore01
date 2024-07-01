using Microsoft.EntityFrameworkCore;
using TPdeEFCore01.Datos.Interfaces;
using TPdeEFCore01.Entidades;

namespace TPdeEFCore01.Datos.Repositorios
{
    public class BrandRepositorio : IBrandsRepositorio
    {
        private readonly ShoesDbContext _dbContext;
        public BrandRepositorio(ShoesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Agregar(Brand brand)
        {
            _dbContext.Brands.Add(brand);
        }

        public void Borrar(Brand brand)
        {
            _dbContext.Brands.Remove(brand);
        }

        public void Editar(Brand brand)
        {
            _dbContext.Brands.Update(brand);
        }

        public bool EstaRelacionado(Brand brand)
        {
            return _dbContext.shoes.Any(b => b.BrandId == brand.BrandId);
        }

        public bool Existe(Brand brand)
        {
            if (brand.BrandId == 0)
            {
                return _dbContext.Brands.Any(b => b.BrandName == brand.BrandName);
            }
            return _dbContext.Brands.Any(b => b.BrandName == brand.BrandName &&
            b.BrandId != brand.BrandId);

        }

        public Brand? GetBrandId(int brandId)
        {
            return _dbContext.Brands.SingleOrDefault(b => b.BrandId == brandId);
        }

        public Brand? GetBrandPorNuevaDesc(string nuevaDescripcion)
        {
            return _dbContext.Brands.AsNoTracking().FirstOrDefault(b => b.BrandName == nuevaDescripcion);

        }

        public List<Shoe>? GetBrands(Brand? brand)
        {
            var lista = _dbContext.shoes
                .Include(b => b.brand)
                .Include(b => b.genre)
                .Include(b => b.sport)
                .Include(b => b.color)
                .Where(shoe => shoe.BrandId == brand.BrandId
                ).ToList();
            return lista;
        }

        public int GetCantidad()
        {
            return _dbContext.Brands.Count();
        }

        public List<Brand> GetLista()
        {
            return _dbContext.Brands
                .OrderBy(b => b.BrandId)
                .ToList();
        }

        public List<Brand> GetListaPaginada(int paginas, int cantidadPorPagina)
        {
            IQueryable<Brand> query = _dbContext.Brands.OrderBy(b => b.BrandId)
             .Select(b => new Brand
             {
                 BrandId = b.BrandId,
                 BrandName = b.BrandName
             });

            return query.Skip((paginas) * cantidadPorPagina)
                        .Take(cantidadPorPagina)
                        .ToList();
        }


    }
}
