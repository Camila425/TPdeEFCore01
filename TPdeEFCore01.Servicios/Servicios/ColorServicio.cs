using TPdeEFCore01.Datos.Interfaces;
using TPdeEFCore01.Datos;
using TPdeEFCore01.Entidades;
using TPdeEFCore01.Servicios.Interfaces;

namespace TPdeEFCore01.Servicios.Servicios
{
    public class ColorServicio : IColorServicio
    {
        private readonly IColorsRepositorio _repository;
        private readonly IUnitOfWork _unitOfWork;

        public ColorServicio(IColorsRepositorio repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Borrar(Color Color)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Borrar(Color);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool EstaRelacionado(Color Color)
        {
            try
            {
                return _repository.EstaRelacionado(Color);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Color Color)
        {
            try
            {
                return _repository.Existe(Color);
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

        public Color? GetColorId(int ColorId)
        {
            try
            {
                return _repository.GetColorId(ColorId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Color? GetColorPorNombre(string nuevaDescripcion)
        {
            try
            {
                return _repository.GetColorPorNombre(nuevaDescripcion);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Color> GetLista()
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

        public List<Color>? GetListaPaginada(int paginaActual, int cantidadPorPagina)
        {
            try
            {
                return _repository.GetListaPaginada(paginaActual, cantidadPorPagina);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Color Color)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                if (Color.ColorId == 0)
                {
                    _repository.Agregar(Color);
                }
                else
                {
                    _repository.Editar(Color);
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
