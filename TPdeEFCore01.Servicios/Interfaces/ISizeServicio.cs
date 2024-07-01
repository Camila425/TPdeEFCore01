using TPdeEFCore01.Entidades;
using TPdeEFCore01.Entidades.Enums;

namespace TPdeEFCore01.Servicios.Interfaces
{
    public interface ISizeServicio
    {
        void Borrar(Size size);
        bool EstaRelacionado(Size size);
        bool Existe(Size talle);
        int GetCantidad();
        List<Size> GetLista();
        List<Size>? GetListaPaginada(int pagina, int cantidadPorPagina, Orden? orden = null);
        Size? GetSizeId(int talleIdInt, bool IncluyeZapatos=false);
        void Guardar(Size talle);
    }
}
