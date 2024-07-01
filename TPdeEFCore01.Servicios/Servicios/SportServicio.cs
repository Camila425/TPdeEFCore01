using TPdeEFCore01.Datos.Interfaces;
using TPdeEFCore01.Datos;
using TPdeEFCore01.Entidades;
using TPdeEFCore01.Servicios.Interfaces;

namespace TPdeEFCore01.Servicios.Servicios
{
    public class SportServicio : ISportServicio
    {
        private readonly ISportsRepositorio _repository;
        private readonly IUnitOfWork _unitOfWork;

        public SportServicio(ISportsRepositorio repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Borrar(Sport Sport)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Borrar(Sport);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool EstaRelacionado(Sport Sport)
        {
            try
            {
                return _repository.EstaRelacionado(Sport);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Sport Sport)
        {
            try
            {
                return _repository.Existe(Sport);
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

        public Sport? GetSportId(int SportId)
        {
            try
            {
                return _repository.GetSportId(SportId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Sport> GetLista()
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

        public Sport? GetSportPorNombre(string nuevaDescripcion)
        {
            try
            {
                return _repository.GetSportPorNombre(nuevaDescripcion);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Sport Sport)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                if (Sport.SportId == 0)
                {
                    _repository.Agregar(Sport);
                }
                else
                {
                    _repository.Editar(Sport);
                }
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public List<Sport>? GetListaPaginada(int paginaActual, int cantidadPorPagina)
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

        public List<Shoe>? GetSports(Sport? sport)
        {
            try
            {
                return _repository.GetSports(sport);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
