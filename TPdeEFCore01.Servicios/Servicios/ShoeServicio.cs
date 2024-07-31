using TPdeEFCore01.Datos;
using TPdeEFCore01.Datos.Interfaces;
using TPdeEFCore01.Entidades;
using TPdeEFCore01.Entidades.Dtos;
using TPdeEFCore01.Entidades.Enums;
using TPdeEFCore01.Servicios.Interfaces;

namespace TPdeEFCore01.Servicios.Servicios
{
    public class ShoeServicio : IShoeServicio
    {
        private readonly IShoesRepositorio _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISizeRepositorio _sizeRepositorio;

        public ShoeServicio(IShoesRepositorio repository, IUnitOfWork unitOfWork, ISizeRepositorio sizeRepositorio)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _sizeRepositorio = sizeRepositorio;
        }

        public void AsignarTallesAZapato(Shoe zapatoSinTalle, Size nuevoTalle)
        {
            if (!_repository.ExisteRelacion(zapatoSinTalle, nuevoTalle))
            {
                try
                {
                    _unitOfWork.BeginTransaction();

                    ShoeSizes nuevaRelacion = new ShoeSizes
                    {
                        shoe = zapatoSinTalle,
                        size = nuevoTalle
                    };

                    _repository.AsignarTalleAZapato(nuevaRelacion);
                    Console.WriteLine("Talle Agregado!!!");

                    _unitOfWork.Commit();
                }
                catch (Exception)
                {
                    _unitOfWork.Rollback();
                    throw;
                }
            }
            else
            {
                Console.WriteLine("El zapato ya tiene este talle asignado.");
            }
        }

        public void Borrar(Shoe Shoe)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Borrar(Shoe);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public List<ShoeListDto>? BuscarMarcaEntreDosPrecios(Brand marca, decimal precioMin, decimal precioMax)
        {
            return _repository.BuscarMarcaEntreDosPrecios(marca, precioMin, precioMax);
        }

        public void EliminarTalleDeZapato(Shoe shoe, Size talle)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                if (_repository.ExisteRelacion(shoe, talle))
                {
                    _repository.EliminarTalleDeZapato(shoe.ShoeId, talle.SizeId);
                    _unitOfWork.Commit();
                }
                else
                {
                    throw new Exception("La relacion no existe.");
                }
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool Existe(Shoe Shoe)
        {
            try
            {
                return _repository.Existe(Shoe);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ExisteRelacion(Shoe shoe, Size talle)
        {
            try
            {
                return _repository.ExisteRelacion(shoe, talle);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ExisteShoeSize(ShoeSizes ShoeSize)
        {
            try
            {
                return _repository.ExisteShoeSize(ShoeSize);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ShoeListDto>? FiltrarGeneroYDeporte(Func<Shoe, bool> predicado)
        {
            try
            {
                return _repository.FiltrarGeneroYDeporte(predicado);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ShoeListDto>? FiltrarMarcaYDeporte(Func<Shoe, bool> predicado)
        {
            try
            {
                return _repository.FiltrarMarcaYDeporte(predicado);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(Func<Shoe, bool>? filtro = null)
        {
            return _repository.GetCantidad(filtro);
        }

        public List<Sport>? GetDeportesPorGenero(int genreId)
        {
            try
            {
                return _repository.GetDeportesPorGenero(genreId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Sport>? GetDeportesPorMarca(int BrandId)
        {
            try
            {
                return _repository.GetDeportesPorMarca(BrandId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Shoe> GetLista()
        {
            try
            {
                return _repository.GetLista();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ShoeListDto> GetListaDto()
        {

            try
            {
                return _repository.GetListaDto();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<ShoeListDto>? GetListaPaginada(int paginaActual, int cantidadPorPagina, Orden? orden = null, Brand? brandFiltro = null,
             Genre? GenreFiltro = null, Sport? SportFiltro = null)
        {
            try
            {
                return _repository.GetListaPaginada(paginaActual, cantidadPorPagina, orden, brandFiltro,
                    GenreFiltro, SportFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

      
        public Shoe? GetShoeId(int ShoeId)
        {
            return _repository.GetShoeId(ShoeId);
        }

        public Shoe? GetShoePorId(int shoeId, bool IncluyeSize = false)
        {
            try
            {
                return _repository.GetShoePorId(shoeId, IncluyeSize);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ShoeSizes? GetShoeSizeId(int shoeId, int sizeId)
        {
            try
            {
                return _repository.GetShoeSizeId(shoeId, sizeId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<SizeStockDto>? GetSizePorShoes(int shoeId)
        {
            try
            {
                return _repository.GetSizePorShoes(shoeId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Size> GetTallesPorZapato(int shoeId)
        {
            return _repository.GetTallesPorZapato(shoeId);
        }


        public void Guardar(Shoe Shoe)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                if (Shoe.ShoeId == 0)
                {
                    _repository.Agregar(Shoe);
                }
                else
                {
                    _repository.Editar(Shoe);
                }
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public void GuardarConTalle(Shoe zapato, Size nuevoTalle)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Agregar(zapato);

                if (nuevoTalle.SizeId == 0)
                {
                    _sizeRepositorio.Agregar(nuevoTalle);

                }
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public void GuardarStock(ShoeSizes ShoeSizes)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.AgregarStock(ShoeSizes);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }
    }
}
