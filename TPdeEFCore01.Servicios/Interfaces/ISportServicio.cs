using TPdeEFCore01.Entidades;

namespace TPdeEFCore01.Servicios.Interfaces
{
    public interface ISportServicio
    {
        List<Sport> GetLista();
        void Guardar(Sport Sport);
        bool Existe(Sport Sport);
        void Borrar(Sport Sport);
        Sport? GetSportId(int SportId);
        bool EstaRelacionado(Sport Sport);
        Sport? GetSportPorNombre(string nuevaDescripcion);
        int GetCantidad();
        List<Sport>? GetListaPaginada(int paginaActual, int cantidadPorPagina);
        List<Shoe>? GetSports(Sport? sport);
    }
}
