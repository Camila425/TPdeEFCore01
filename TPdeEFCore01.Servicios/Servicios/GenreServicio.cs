using TPdeEFCore01.Datos.Interfaces;
using TPdeEFCore01.Datos;
using TPdeEFCore01.Entidades;
using TPdeEFCore01.Servicios.Interfaces;

namespace TPdeEFCore01.Servicios.Servicios
{
    public class GenreServicio : IGenreServicio
    {
        private readonly IGenresRepositorio _repository;
        private readonly IUnitOfWork _unitOfWork;
        public GenreServicio(IGenresRepositorio repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public void Borrar(Genre Genre)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Borrar(Genre);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool EstaRelacionado(Genre Genre)
        {
            try
            {
                return _repository.EstaRelacionado(Genre);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Genre Genre)
        {
            try
            {
                return _repository.Existe(Genre);
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

        public Genre? GetGenreId(int GenreId)
        {
            try
            {
                return _repository.GetGenreId(GenreId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Genre? GetGenrePorNombre(string nuevaDescripcion)
        {
            try
            {
                return _repository.GetGenrePorNombre(nuevaDescripcion);
            }
            catch (Exception)
            {

                throw;
            }
        }

     
        public List<Genre> GetLista()
        {
            return _repository.GetLista();
        }

        public List<Genre>? GetListaPaginada(int paginaActual, int cantidadPorPagina)
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

        public void Guardar(Genre Genre)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                if (Genre.GenreId == 0)
                {
                    _repository.Agregar(Genre);
                }
                else
                {
                    _repository.Editar(Genre);
                }
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public List<Shoe>? GetGenres(Genre? genre)
        {
            try
            {
                return _repository.GetGenres(genre);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Shoe>? GetGenreySport(Genre? genre, Sport? sport)
        {
            return _repository.GetGenreySport(genre, sport);
        }
    }
}
