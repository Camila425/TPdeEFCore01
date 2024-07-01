using TPdeEFCore01.Entidades;

namespace TPdeEFCore01.Datos.Interfaces
{
    public interface ISportsRepositorio
    {
        List<Sport> GetLista();
        Sport? GetSportId(int SportId);
        void Borrar(Sport Sport);
        bool EstaRelacionado(Sport Sport);
        int GetCantidad();
        bool Existe(Sport Sport);
        void Agregar(Sport Sport);
        void Editar(Sport Sport);
        Sport? GetSportPorNombre(string nuevaDescripcion);
        List<Sport>? GetListaPaginada(int paginaActual, int cantidadPorPagina);
        List<Shoe>? GetSports(Sport? sport);
    }
}
