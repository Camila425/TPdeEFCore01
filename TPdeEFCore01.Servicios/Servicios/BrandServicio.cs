using TPdeEFCore01.Datos;
using TPdeEFCore01.Datos.Interfaces;
using TPdeEFCore01.Entidades;
using TPdeEFCore01.Servicios.Interfaces;

namespace TPdeEFCore01.Servicios.Repositorios
{
    public class BrandServicio : IBrandServicio
    {
        private readonly IBrandsRepositorio _repository;
        private readonly IUnitOfWork _unitOfWork;
        public BrandServicio(IBrandsRepositorio repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Borrar(Brand brand)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Borrar(brand);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool EstaRelacionado(Brand brand)
        {
            try
            {
                return _repository.EstaRelacionado(brand);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Brand brand)
        {
            try
            {
                return _repository.Existe(brand);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Brand? GetBrandId(int BrandId)
        {
            try
            {
                return _repository.GetBrandId(BrandId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Brand? GetBrandPorNombre(string nuevaDescripcion)
        {
            try
            {
                return _repository.GetBrandPorNuevaDesc(nuevaDescripcion);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Shoe>? GetBrands(Brand? brand)
        {
            try
            {
                return _repository.GetBrands(brand);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad()
        {
            return _repository.GetCantidad();
        }

        public List<Brand> GetLista()
        {
            return _repository.GetLista();
        }

        public List<Brand>? GetListaPaginada(int paginas, int cantidadPorPagina)
        {
            try
            {
                return _repository.GetListaPaginada(paginas, cantidadPorPagina);
            }
            catch (Exception)
            {

                throw;
            }
        }

     

        public void Guardar(Brand brand)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                if (brand.BrandId == 0)
                {
                    _repository.Agregar(brand);
                }
                else
                {
                    _repository.Editar(brand);
                }
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
