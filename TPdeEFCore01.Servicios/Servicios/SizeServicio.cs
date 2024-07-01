using TPdeEFCore01.Datos;
using TPdeEFCore01.Datos.Interfaces;
using TPdeEFCore01.Entidades;
using TPdeEFCore01.Entidades.Enums;
using TPdeEFCore01.Servicios.Interfaces;

namespace TPdeEFCore01.Servicios.Servicios
{
    public class SizeServicio : ISizeServicio
    {
        private readonly ISizeRepositorio _repository;
        private readonly IUnitOfWork _unitOfWork;

        public SizeServicio(ISizeRepositorio repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Borrar(Size size)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Borrar(size);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool EstaRelacionado(Size size)
        {
            try
            {
                return _repository.EstaRelacionado(size);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Size talle)
        {
            try
            {
                return _repository.Existe(talle);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad()
        {
            try
            {
                return _repository.GetCantidad();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Size> GetLista()
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

       

        public List<Size>? GetListaPaginada(int pagina, int cantidadPorPagina, Orden? orden = null)
        {
            try
            {
                return _repository.GetListaPaginada(pagina, cantidadPorPagina,orden);
            }
            catch (Exception)
            {

                throw;
            }
        }

  
        public Size? GetSizeId(int talleIdInt, bool IncluyeZapatos = false)
        {
            try
            {
                return _repository.GetSizeId(talleIdInt, IncluyeZapatos);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Size talle)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                if (talle.SizeId == 0)
                {
                    _repository.Agregar(talle);
                }
                else
                {
                    _repository.Editar(talle);
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
