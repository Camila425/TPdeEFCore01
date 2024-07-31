using TPdeEFCore01.Entidades;
using TPdeEFCore01.Entidades.Dtos;
using TPdeEFCore01.Entidades.Enums;

namespace TPdeEFCore01.Datos.Interfaces
{
    public interface IShoesRepositorio
    {
        List<ShoeListDto> GetListaDto();
        List<Shoe> GetLista();

        Shoe? GetShoeId(int ShoeId);
        void Borrar(Shoe Shoe);
        int GetCantidad(Func<Shoe, bool>? filtro = null);
        bool Existe(Shoe Shoe);
        void Agregar(Shoe Shoe);
        void Editar(Shoe Shoe);
      
        List<ShoeListDto>? GetListaPaginada(int paginaActual, int cantidadPorPagina, Orden? orden = null, Brand? brandFiltro = null,
             Genre? GenreFiltro = null, Sport? sportFiltro = null);
        List<ShoeListDto>? FiltrarMarcaYDeporte(Func<Shoe, bool> predicado);
        List<Sport>? GetDeportesPorMarca(int sportId);
        List<ShoeListDto>? FiltrarGeneroYDeporte(Func<Shoe, bool> predicado);
        List<Sport>? GetDeportesPorGenero(int genreId);
        List<ShoeListDto>? BuscarMarcaEntreDosPrecios(Brand marca, decimal precioMin, decimal precioMax);
        Shoe? GetShoePorId(int shoeId, bool incluyeSize);
        List<SizeStockDto>? GetSizePorShoes(int shoeId);
        bool ExisteRelacion(Shoe shoe, Size talle);
        void AsignarTalleAZapato(ShoeSizes nuevaRelacion);
        void EliminarTalleDeZapato(int shoeId, int sizeId);
        void AsignarTallesAZapato(ShoeSizes nuevaRelacion);
        List<Size> GetTallesPorZapato(int shoeId);
        bool ExisteShoeSize(ShoeSizes shoeSize);
        void AgregarStock(ShoeSizes shoeSizes);
        ShoeSizes? GetShoeSizeId(int shoeId, int sizeId);
    }
}
