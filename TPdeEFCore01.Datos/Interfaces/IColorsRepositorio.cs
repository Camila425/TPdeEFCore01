using TPdeEFCore01.Entidades;

namespace TPdeEFCore01.Datos.Interfaces
{
    public interface IColorsRepositorio
    {
        List<Color> GetLista();
        Color? GetColorId(int ColorId);
        void Borrar(Color Color);
        bool EstaRelacionado(Color Color);
        int GetCantidad();
        bool Existe(Color Color);
        void Agregar(Color Color);
        void Editar(Color Color);
        Color? GetColorPorNombre(string nuevaDescripcion);
        List<Color>? GetListaPaginada(int paginaActual, int cantidadPorPagina);
    }
}
