using TPdeEFCore01.Entidades;

namespace TPdeEFCore01.Datos.Interfaces
{
    public interface IBrandsRepositorio
    {
        List<Brand> GetLista();
        Brand? GetBrandId(int brandId);
        void Borrar(Brand brand);
        bool EstaRelacionado(Brand brand);
        int GetCantidad();
        bool Existe(Brand brand);
        void Agregar(Brand brand);
        void Editar(Brand brand);
        Brand? GetBrandPorNuevaDesc(string nuevaDescripcion);
        List<Brand>? GetListaPaginada(int paginas, int cantidadPorPagina);
        List<Shoe>? GetBrands(Brand? brand);
    }
}
