using TPdeEFCore01.Entidades;
using TPdeEFCore01.Entidades.Dtos;
using TPdeEFCore01.Entidades.Enums;

namespace TPdeEFCore01.Servicios.Interfaces
{
    public interface IShoeServicio
    {
        List<ShoeListDto> GetListaDto();
        List<Shoe> GetLista();

        void Guardar(Shoe Shoe);
        bool Existe(Shoe Shoe);
        void Borrar(Shoe Shoe);
        Shoe? GetShoeId(int ShoeId);
        int GetCantidad(Func<Shoe, bool>? filtro = null);
        List<ShoeListDto>? GetListaPaginada(int paginaActual, int cantidadPorPagina, Orden? orden = null, Brand? brandFiltro=null,
             Genre? GenreFiltro = null, Sport? SportFiltro = null);
        List<ShoeListDto>? FiltrarMarcaYDeporte(Func<Shoe, bool> predicado);
        List<Sport>? GetDeportesPorMarca(int sportId);
        List<ShoeListDto>? FiltrarGeneroYDeporte(Func<Shoe, bool> predicado);
        List<Sport>? GetDeportesPorGenero(int genreId);
        List<ShoeListDto>? BuscarMarcaEntreDosPrecios(Brand marca, decimal precioMin, decimal precioMax);
        Shoe? GetShoePorId(int shoeId,bool IncluyeSize=false);
        List<SizeStockDto>? GetSizePorShoes(int shoeId);
        bool ExisteRelacion(Shoe shoe, Size talle);
        void EliminarTalleDeZapato(Shoe shoe, Size talle);
        void GuardarConTalle(Shoe zapato, Size nuevoTalle);
        void AsignarTallesAZapato(Shoe zapatoSinTalle, Size nuevoTalle);
        List<Size> GetTallesPorZapato(int shoeId);
        bool ExisteShoeSize(ShoeSizes ShoeSizes);
        void GuardarStock(ShoeSizes zapato);
        ShoeSizes? GetShoeSizeId(int shoeId, int sizeId);
    }
}
