using TPdeEFCore01.Entidades;

namespace TPdeEFCore01.Datos.Interfaces
{
    public interface IGenresRepositorio
    {
        List<Genre> GetLista();
        Genre? GetGenreId(int GenreId);
        void Borrar(Genre Genre);
        bool EstaRelacionado(Genre Genre);
        int GetCantidad();
        bool Existe(Genre Genre);
        void Agregar(Genre Genre);
        void Editar(Genre Genre);
        Genre? GetGenrePorNombre(string nuevaDescripcion);
        List<Genre>? GetListaPaginada(int paginaActual, int cantidadPorPagina);
        List<Shoe>? GetGenres(Genre? genre);
        List<Shoe>? GetGenreySport(Genre? genre, Sport? sport);
    }
}
