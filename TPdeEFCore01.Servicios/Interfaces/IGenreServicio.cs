using TPdeEFCore01.Entidades;

namespace TPdeEFCore01.Servicios.Interfaces
{
    public interface IGenreServicio
    {
        List<Genre> GetLista();
        void Guardar(Genre Genre);
        bool Existe(Genre Genre);
        void Borrar(Genre Genre);
        Genre? GetGenreId(int GenreId);
        bool EstaRelacionado(Genre Genre);
        Genre? GetGenrePorNombre(string nuevaDescripcion);
        int GetCantidad();
        List<Genre>? GetListaPaginada(int paginaActual, int cantidadPorPagina);
        List<Shoe>? GetGenres(Genre? genre);
        List<Shoe>? GetGenreySport(Genre? genre, Sport? sport);
    }
}
