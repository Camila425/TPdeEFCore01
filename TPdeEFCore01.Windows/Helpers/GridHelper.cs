using TPdeEFCore01.Entidades;
using TPdeEFCore01.Entidades.Dtos;
using Color = TPdeEFCore01.Entidades.Color;
using Size = TPdeEFCore01.Entidades.Size;
namespace TPdeEFCore01.Windows.Helpers
{
    public static class GridHelper
    {
        public static void LimpiarGrilla(DataGridView DataGridView)
        {
            DataGridView.Rows.Clear();
        }

        public static DataGridViewRow ConstruirFila(DataGridView DataGridView)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DataGridView);
            return r;

        }

        public static void QuitarFila(DataGridViewRow r, DataGridView DataGridView)
        {
            DataGridView.Rows.Remove(r);
        }
        public static void SetearFila(DataGridViewRow r, object item)
        {
            switch (item)
            {
                case Brand brand:
                    r.Cells[0].Value = brand.BrandName;
                    break;
                case Genre genre:
                    r.Cells[0].Value = genre.GenreName;
                    break;
                case Sport sport:
                    r.Cells[0].Value = sport.SportName;
                    break;
                case Color color:
                    r.Cells[0].Value = color.ColorName;
                    break;
                case ShoeListDto shoeListDto:
                    r.Cells[0].Value = shoeListDto.Descripcion;
                    r.Cells[1].Value = shoeListDto.BrandName;
                    r.Cells[2].Value = shoeListDto.GenreName;
                    r.Cells[3].Value = shoeListDto.SportName;
                    r.Cells[4].Value = shoeListDto.ColorName;
                    r.Cells[5].Value = shoeListDto.Model;
                    r.Cells[6].Value = shoeListDto.Price;
                    r.Cells[7].Value = shoeListDto.QuantityInStock;
                    break;
                case Shoe shoe:
                    r.Cells[0].Value = shoe.Description;
                    r.Cells[1].Value = shoe.brand.BrandName;
                    r.Cells[2].Value = shoe.genre.GenreName;
                    r.Cells[3].Value = shoe.sport.SportName;
                    r.Cells[4].Value = shoe.color.ColorName;
                    r.Cells[5].Value = shoe.Model;
                    r.Cells[6].Value = shoe.Price;
                    break;
                case Size size:
                    r.Cells[0].Value = size.SizeNumber;
                    break;
                default:
                    break;

            }
            r.Tag = item;
        }

        public static void AgregarFila(DataGridViewRow r, DataGridView DataGridView)
        {
            DataGridView.Rows.Add(r);
        }

        public static void MostrarDatosEnGrilla<T>(List<T> lista, DataGridView datosdataGridView) where T: class
        {
            LimpiarGrilla(datosdataGridView);
            foreach (T t in lista)
            {
                var r = ConstruirFila(datosdataGridView);
                SetearFila(r, t);
                AgregarFila(r, datosdataGridView);
            }
        }
    }
}
