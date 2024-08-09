using Microsoft.EntityFrameworkCore;
using TPdeEFCore01.Datos.Interfaces;
using TPdeEFCore01.Entidades;
using TPdeEFCore01.Entidades.Dtos;
using TPdeEFCore01.Entidades.Enums;

namespace TPdeEFCore01.Datos.Repositorios
{
    public class ShoeRepositorio : IShoesRepositorio
    {
        private readonly ShoesDbContext _dbContext;
        public ShoeRepositorio(ShoesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Agregar(Shoe Shoe)
        {

            var MarcaExistente = _dbContext.Brands.FirstOrDefault(b => b.BrandId == Shoe.BrandId);
            if (MarcaExistente != null)
            {
                _dbContext.Attach(MarcaExistente);
                Shoe.brand = MarcaExistente;
            }

            var GeneroExistente = _dbContext.Genres.FirstOrDefault(g => g.GenreId == Shoe.GenreId);
            if (GeneroExistente != null)
            {
                _dbContext.Attach(GeneroExistente);
                Shoe.genre = GeneroExistente;
            }

            var SportExistente = _dbContext.Sports.FirstOrDefault(s => s.SportId == Shoe.SportId);
            if (SportExistente != null)
            {
                _dbContext.Attach(SportExistente);
                Shoe.sport = SportExistente;
            }

            var ColorsExistente = _dbContext.Colors.FirstOrDefault(c => c.ColorId == Shoe.ColorId);
            if (ColorsExistente != null)
            {
                _dbContext.Attach(ColorsExistente);
                Shoe.color = ColorsExistente;
            }

            _dbContext.shoes.Add(Shoe);
        }

        public void Borrar(Shoe Shoe)
        {
            _dbContext.shoes.Remove(Shoe);
        }



        public void Editar(Shoe Shoe)
        {
            var MarcaExistente = _dbContext.Brands.FirstOrDefault(b => b.BrandId == Shoe.BrandId);
            if (MarcaExistente != null)
            {
                _dbContext.Attach(MarcaExistente);
                Shoe.brand = MarcaExistente;
            }

            var GeneroExistente = _dbContext.Genres.FirstOrDefault(g => g.GenreId == Shoe.GenreId);
            if (GeneroExistente != null)
            {
                _dbContext.Attach(GeneroExistente);
                Shoe.genre = GeneroExistente;
            }

            var SportExistente = _dbContext.Sports.FirstOrDefault(s => s.SportId == Shoe.SportId);
            if (SportExistente != null)
            {
                _dbContext.Attach(SportExistente);
                Shoe.sport = SportExistente;
            }

            var ColorsExistente = _dbContext.Colors.FirstOrDefault(c => c.ColorId == Shoe.ColorId);
            if (ColorsExistente != null)
            {
                _dbContext.Attach(ColorsExistente);
                Shoe.color = ColorsExistente;
            }

            _dbContext.shoes.Update(Shoe);
        }

        public bool Existe(Shoe Shoe)
        {
            if (Shoe.ShoeId == 0)
            {
                return _dbContext.shoes.Any(s => s.Description == Shoe.Description
                && s.BrandId == Shoe.BrandId && s.GenreId == Shoe.GenreId && s.SportId == Shoe.SportId &&
                s.ColorId == Shoe.ColorId && s.Model == Shoe.Model);
            }

            return _dbContext.shoes.Any(s => s.Description == Shoe.Description
            && s.BrandId == Shoe.BrandId && s.GenreId == Shoe.GenreId && s.SportId == Shoe.SportId &&
            s.ColorId == Shoe.ColorId && s.Model == Shoe.Model && s.ShoeId != Shoe.ShoeId);
        }

        public List<ShoeListDto>? FiltrarGeneroYDeporte(Func<Shoe, bool> predicado)
        {
            if (predicado == null)
            {
                throw new ArgumentNullException(nameof(predicado));
            }

            var shoes = _dbContext.shoes
                .Include(b => b.brand)
                .Include(d => d.sport)
                .Include(g => g.genre)
                .Include(c => c.color)
                .Where(predicado)
                .ToList();

            return shoes.Select(s => new ShoeListDto
            {
                ShoeId = s.ShoeId,
                Descripcion = s.Description,
                BrandName = s.brand?.BrandName ?? "N/A",
                GenreName = s.genre?.GenreName ?? "N/A",
                SportName = s.sport?.SportName ?? "N/A",
                ColorName = s.color?.ColorName ?? "N/A",
                Model = s.Model,
                Price = s.Price
            }).ToList();
        }

        public List<ShoeListDto>? FiltrarMarcaYDeporte(Func<Shoe, bool> predicado)
        {
            if (predicado == null)
            {
                throw new ArgumentNullException(nameof(predicado));
            }

            var shoes = _dbContext.shoes
                .Include(b => b.brand)
                .Include(d => d.sport)
                .Include(g => g.genre)
                .Include(c => c.color)
                .Where(predicado)
                .ToList();

            return shoes.Select(s => new ShoeListDto
            {
                ShoeId = s.ShoeId,
                Descripcion = s.Description,
                BrandName = s.brand?.BrandName ?? "N/A",
                GenreName = s.genre?.GenreName ?? "N/A",
                SportName = s.sport?.SportName ?? "N/A",
                ColorName = s.color?.ColorName ?? "N/A",
                Model = s.Model,
                Price = s.Price
            }).ToList();
        }

        public int GetCantidad(Func<Shoe, bool>? filtro = null)
        {
            if (filtro != null)
            {
                return _dbContext.shoes.Count(filtro);
            }
            else
            {
                return _dbContext.shoes.Count();
            }
        }
        public List<ShoeListDto>? BuscarMarcaEntreDosPrecios(Brand marca, decimal precioMin, decimal precioMax)
        {
            return _dbContext.shoes
           .Where(s => s.brand == marca && s.Price >= precioMin && s.Price <= precioMax)
           .Select(s => new ShoeListDto
           {
               ShoeId = s.ShoeId,
               Descripcion = s.Description,
               BrandName = s.brand != null ? s.brand.BrandName : string.Empty,
               GenreName = s.genre != null ? s.genre.GenreName : string.Empty,
               SportName = s.sport != null ? s.sport.SportName : string.Empty,
               ColorName = s.color != null ? s.color.ColorName : string.Empty,
               Model = s.Model,
               Price = s.Price
           }).ToList();
        }

        public List<Sport>? GetDeportesPorGenero(int genreId)
        {
            return _dbContext.shoes
                             .Include(s => s.genre)
                             .Where(s => s.GenreId == genreId)
                             .Select(s => s.sport)
                             .Distinct()
                             .ToList();
        }

        public List<Sport>? GetDeportesPorMarca(int BranId)
        {
            return _dbContext.shoes
                           .Include(s => s.brand)
                           .Where(s => s.BrandId == BranId)
                           .Select(s => s.sport)
                           .Distinct()
                           .ToList();
        }

        public List<Shoe> GetLista()
        {
            return _dbContext.shoes.ToList();
        }

        public List<ShoeListDto> GetListaDto()
        {
            return _dbContext.shoes
                .Include(s => s.brand)
                .Include(s => s.genre)
                .Include(s => s.sport)
                .Include(s => s.color)
                .Select(s => new ShoeListDto
                {
                    ShoeId = s.ShoeId,
                    Descripcion = s.Description,
                    BrandName = s.brand != null ? s.brand.BrandName : string.Empty,
                    GenreName = s.genre != null ? s.genre.GenreName : string.Empty,
                    SportName = s.sport != null ? s.sport.SportName : string.Empty,
                    ColorName = s.color != null ? s.color.ColorName : string.Empty,
                    Model = s.Model,
                    Price = s.Price
                }).ToList();
        }

        public List<ShoeListDto>? GetListaPaginada(int paginaActual, int cantidadPorPagina, Orden? orden = null, Brand? brandFiltro = null,
             Genre? GenreFiltro = null, Sport? SportFiltro = null)
        {
            IQueryable<Shoe> query = _dbContext.shoes
                .OrderBy(s => s.ShoeId)
                .Include(s => s.brand)
                .Include(s => s.genre)
                .Include(s => s.sport)
                .Include(s => s.color)
                .Include(s => s.shoeSizes)
                .AsNoTracking();

            if (brandFiltro != null)
            {
                query = query
                    .Where(b => b.BrandId == brandFiltro.BrandId);
            }
            if (GenreFiltro != null)
            {
                query = query
                    .Where(g => g.GenreId == GenreFiltro.GenreId);
            }
            if (SportFiltro != null)
            {
                query = query
                    .Where(s => s.SportId == SportFiltro.SportId);
            }

            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.AZ:
                        query = query.OrderBy(s => s.Description);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(s => s.Description);
                        break;
                    case Orden.MenorPrecio:
                        query = query.OrderBy(s => s.Price);
                        break;
                    case Orden.MayorPrecio:
                        query = query.OrderByDescending(s => s.Price);
                        break;
                    default:
                        break;
                }
            }
            List<Shoe> listaPaginada = query
                .AsNoTracking()
                .Skip(paginaActual * cantidadPorPagina)
                .Take(cantidadPorPagina)
                .ToList();


            List<ShoeListDto> listaDto = listaPaginada
                .Select(s => new ShoeListDto
                {
                    ShoeId = s.ShoeId,
                    Descripcion = s.Description,
                    BrandName = s.brand != null ? s.brand.BrandName : string.Empty,
                    GenreName = s.genre != null ? s.genre.GenreName : string.Empty,
                    SportName = s.sport != null ? s.sport.SportName : string.Empty,
                    ColorName = s.color != null ? s.color.ColorName : string.Empty,
                    Model = s.Model,
                    Price = s.Price,
                    QuantityInStock = s.shoeSizes.Count()

                })
                .ToList();

            return listaDto;

        }

        public Shoe? GetShoeId(int ShoeId)
        {
            return _dbContext.shoes.Include(s => s.brand).Include(s => s.genre)
                .Include(s => s.sport).Include(s => s.color)
               .FirstOrDefault(s => s.ShoeId == ShoeId);
        }



        public Shoe? GetShoePorId(int shoeId, bool incluyeSize)
        {
            var Query = _dbContext.shoes;
            if (incluyeSize)
            {
                return Query.Include(s => s.shoeSizes)
                            .ThenInclude(ss => ss.size)
                            .FirstOrDefault(s => s.ShoeId == shoeId);
            }
            return Query.FirstOrDefault(s => s.ShoeId == shoeId);
        }

        public List<SizeStockDto>? GetSizePorShoes(int shoeId)
        {
            return _dbContext.shoeSizes
                   .Include(ss => ss.size)
           .Where(ss => ss.ShoeId == shoeId)
           .Select(ss => new SizeStockDto
           {
               SizeNumber = ss.size.SizeNumber,
               QuantityInStock = ss.QuantityInStock
           }).ToList();
         
        }

        public bool ExisteRelacion(Shoe shoe, Size talle)
        {
            if (shoe == null || talle == null)
            {
                return false;
            }

            return _dbContext.shoeSizes.Any(ss => ss.ShoeId == shoe.ShoeId && ss.SizeId == talle.SizeId);
        }

        public void AsignarTalleAZapato(ShoeSizes nuevaRelacion)
        {
            _dbContext.Set<ShoeSizes>().Add(nuevaRelacion);
        }

        public void EliminarTalleDeZapato(int shoeId, int sizeId)
        {
            var relacion = _dbContext.Set<ShoeSizes>().FirstOrDefault(ss => ss.ShoeId == shoeId && ss.SizeId == sizeId);
            if (relacion != null)
            {
                _dbContext.Set<ShoeSizes>().Remove(relacion);
            }
        }

        public void AsignarTallesAZapato(ShoeSizes nuevaRelacion)
        {
            _dbContext.Set<ShoeSizes>().Add(nuevaRelacion);
        }
        public List<Size> GetTallesPorZapato(int shoeId)
        {
            return _dbContext.shoeSizes
                     .Where(ss => ss.ShoeId == shoeId)
                     .Select(ss => ss.size)
                     .ToList();
        }

        public bool ExisteShoeSize(ShoeSizes shoeSize)
        {
            return _dbContext.shoeSizes.Any(s => s.ShoeId == shoeSize.ShoeId && s.SizeId == shoeSize.SizeId);
        }

        public void AgregarStock(ShoeSizes shoeSizes)
        {
            var existShoeSize = _dbContext.shoeSizes.FirstOrDefault(s => s.ShoeId == shoeSizes.ShoeId
            && s.SizeId == shoeSizes.SizeId);
            if (existShoeSize != null)
            {
                existShoeSize.QuantityInStock += shoeSizes.QuantityInStock;
                _dbContext.shoeSizes.Update(existShoeSize);
            }
            else
            {
                Console.WriteLine("El registro ShoeSize no existe");
            }

        }

        public ShoeSizes? GetShoeSizeId(int shoeId, int sizeId)
        {
            return _dbContext.shoeSizes.FirstOrDefault(s => s.ShoeId == shoeId && s.SizeId == sizeId);

        }

        public Size GetSizeIdShoe()
        {
            return _dbContext.Sizes.FirstOrDefault();
        }

        public Shoe GetShoeId()
        {
            return _dbContext.shoes.FirstOrDefault();
        }
    }
}
