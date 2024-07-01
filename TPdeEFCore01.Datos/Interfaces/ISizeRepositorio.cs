using TPdeEFCore01.Entidades;
using TPdeEFCore01.Entidades.Enums;

namespace TPdeEFCore01.Datos.Interfaces
{
    public interface ISizeRepositorio
    {
        void Agregar(Size talle);
        void Borrar(Size size);
        void Editar(Size talle);
        bool EstaRelacionado(Size size);
        bool Existe(Size talle);
        int GetCantidad();
        List<Size> GetLista();
        List<Size>? GetListaOrdenadaPorTalle(int paginaActual, int cantidadPorPagina, Orden? orden = null);
        List<Size>? GetListaPaginada(int pagina, int cantidadPorPagina, Orden? orden = null);
        Size? GetSizeId(int talleIdInt, bool incluyeZapatos);
    }
}
