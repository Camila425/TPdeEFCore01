using TPdeEFCore01.Entidades;

namespace TPdeEFCore01.Servicios.Interfaces
{
    public interface IBrandServicio
    {
        List<Brand> GetLista();
        void Guardar(Brand brand);
        bool Existe(Brand brand);
        void Borrar(Brand brand);
        Brand? GetBrandId(int BrandId);
        bool EstaRelacionado(Brand brand);
        Brand? GetBrandPorNombre(string nuevaDescripcion);
        int GetCantidad();
        List<Brand>? GetListaPaginada(int paginas, int cantidadPorPagina);
        List<Shoe>? GetBrands(Brand? brand);
    }
}
