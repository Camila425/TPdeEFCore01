using TPdeEFCore01.Entidades;

namespace TPdeEFCore01.Servicios.Interfaces
{
    public interface IColorServicio
    {
        List<Color> GetLista();
        void Guardar(Color Color);
        bool Existe(Color Color);
        void Borrar(Color Color);
        Color? GetColorId(int ColorId);
        bool EstaRelacionado(Color Color);
        Color? GetColorPorNombre(string nuevaDescripcion);
        int GetCantidad();
        List<Color>? GetListaPaginada(int paginaActual, int cantidadPorPagina);
    }
}
