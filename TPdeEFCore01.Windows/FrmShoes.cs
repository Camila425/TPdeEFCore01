using Microsoft.Extensions.DependencyInjection;
using TPdeEFCore01.Entidades;
using TPdeEFCore01.Entidades.Dtos;
using TPdeEFCore01.Entidades.Enums;
using TPdeEFCore01.Servicios.Interfaces;
using TPdeEFCore01.Windows.Helpers;
using Color = System.Drawing.Color;
using MessageBox = System.Windows.Forms.MessageBox;
using Size = TPdeEFCore01.Entidades.Size;
using SystemColors = System.Drawing.SystemColors;

namespace TPdeEFCore01.Windows
{
    public partial class FrmShoes : Form
    {
        private readonly IShoeServicio _servicio;
        private readonly IServiceProvider _serviceProvider;
        private List<ShoeListDto>? listaShoe;
        //paginacion
        private int cantidadPorPagina = 5;
        private int Cantregistros;
        private int paginas;
        private int paginaActual = 0;
        private Orden orden = Orden.SinOrden;

        private bool FiltrarOn = false;
        private Brand? BrandFiltro = null;
        private Genre? GenreFiltro = null;
        private Sport? SportFiltro = null;

        public FrmShoes(IShoeServicio servicio, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _servicio = servicio;
            _serviceProvider = serviceProvider;
        }
        private void FrmShoes_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboMarca(_serviceProvider, ref marcassCb);
            CombosHelper.CargarComboGenre(_serviceProvider, ref GenerostoolStripComboBox);
            CombosHelper.CargarComboSport(_serviceProvider, ref DeportestoolStripComboBox);
            RecargarGrilla();
        }
        private void SalirtoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void RecargarGrilla()
        {
            try
            {
                Cantregistros = _servicio.GetCantidad();
                paginas = FormHelper.CalcularPaginas(Cantregistros, cantidadPorPagina);
                CantRegistrostextBox.Text = paginas.ToString();
                CombosHelper.CargarCombosPaginas(paginas, ref PaginascomboBox);
                listaShoe = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina);
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(DatosdataGridView);
            if (listaShoe is not null)
            {
                foreach (var item in listaShoe)
                {
                    DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                    GridHelper.SetearFila(r, item);
                    GridHelper.AgregarFila(r, DatosdataGridView);
                }

            }
        }

        private void NuevotoolStripButton_Click(object sender, EventArgs e)
        {
            FrmShoeAE frm = new FrmShoeAE(_serviceProvider) { Text = "Agregar una Nueva Marca" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Shoe? shoe = frm.GetShoe();

                if (shoe is not null)
                {
                    if (!_servicio.Existe(shoe))
                    {
                        _servicio.Guardar(shoe);
                        var r = GridHelper.ConstruirFila(DatosdataGridView);
                        GridHelper.SetearFila(r, shoe);
                        GridHelper.AgregarFila(r, DatosdataGridView);
                        MessageBox.Show("Registro Agregado!!", "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        RecargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Registro ya  Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            try
            {
                var r = DatosdataGridView.SelectedRows[0];
                ShoeListDto shoeListDto = (ShoeListDto)r.Tag;
                if (shoeListDto is not null)
                {
                    DialogResult dr = MessageBox.Show($"¿Confirma la baja de {shoeListDto.Descripcion}?",
                               "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                    var shoe = _servicio.GetShoeId(shoeListDto.ShoeId);
                    if (shoe != null)
                    {
                        _servicio.Borrar(shoe);
                        GridHelper.QuitarFila(r, DatosdataGridView);
                        MessageBox.Show("Registro borrado!!!", "Mensaje", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EditartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            ShoeListDto shoeListDto = (ShoeListDto)r.Tag;


            var shoe = _servicio.GetShoeId(shoeListDto.ShoeId);
            FrmShoeAE frm = new FrmShoeAE(_serviceProvider) { Text = "Editar una Zapatilla" };
            frm.SetShoe(shoe);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                shoe = frm.GetShoe();
                if (shoe is not null)
                {
                    if (!_servicio.Existe(shoe))
                    {
                        _servicio.Guardar(shoe);
                        GridHelper.SetearFila(r, shoe);
                        MessageBox.Show("Registro Editado!!", "Mensaje", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        RecargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Zapatilla Ya Existe!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Primerobutton_Click(object sender, EventArgs e)
        {
            paginaActual = 0;
            PaginascomboBox.SelectedIndex = paginaActual;
            listaShoe = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina, orden, BrandFiltro, GenreFiltro, SportFiltro);
            MostrarDatosEnGrilla();
        }

        private void anteriorbutton_Click(object sender, EventArgs e)
        {
            paginaActual--;
            if (paginaActual < 0)
            {
                paginaActual = 0;
            }
            PaginascomboBox.SelectedIndex = paginaActual;
            listaShoe = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina, orden, BrandFiltro, GenreFiltro, SportFiltro);
            MostrarDatosEnGrilla();
        }

        private void Siguientebutton_Click(object sender, EventArgs e)
        {
            paginaActual++;
            if (paginaActual >= paginas)
            {
                paginaActual = paginas - 1;
            }
            PaginascomboBox.SelectedIndex = paginaActual;
            listaShoe = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina, orden, BrandFiltro, GenreFiltro, SportFiltro);
            MostrarDatosEnGrilla();
        }

        private void Ultimobutton_Click(object sender, EventArgs e)
        {
            paginaActual = paginas - 1;
            PaginascomboBox.SelectedIndex = paginaActual;
            listaShoe = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina, orden, BrandFiltro, GenreFiltro, SportFiltro);
            MostrarDatosEnGrilla();
        }

        private void PaginascomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            paginaActual = PaginascomboBox.SelectedIndex;
            listaShoe = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina, orden, BrandFiltro, GenreFiltro, SportFiltro);
            MostrarDatosEnGrilla();

        }

        private void ActualizartoolStripButton_Click(object sender, EventArgs e)
        {
            FiltrarOn = false;
            FltrarrtoolStripButton.Enabled = true;
            BrandFiltro = null;
            GenreFiltro = null;
            SportFiltro = null;
            RecargarGrilla();
            FltrarrtoolStripButton.BackColor = SystemColors.Control;
            BuscarMaryDeptoolStripButton.BackColor = SystemColors.Control;
            GeneroYDeportetoolStripButton.BackColor = SystemColors.Control;


        }

        private void marcassCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FiltrarOn)
            {
                if (marcassCb.SelectedIndex > 0)
                {
                    FiltrarOn = true;
                    var servicio = _serviceProvider.GetService<IBrandServicio>();
                    BrandFiltro = servicio?.GetBrandPorNombre(marcassCb.Text);

                    Cantregistros = _servicio.GetCantidad(b => b.brand == BrandFiltro);

                    paginas = FormHelper.CalcularPaginas(Cantregistros, cantidadPorPagina);
                    CantRegistrostextBox.Text = paginas.ToString();
                    CombosHelper.CargarCombosPaginas(paginas, ref PaginascomboBox);
                    listaShoe = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina, orden, BrandFiltro, GenreFiltro, SportFiltro);
                    MostrarDatosEnGrilla();
                    FltrarrtoolStripButton.BackColor = Color.Red;
                    FltrarrtoolStripButton.Enabled = false;
                }
                else
                {
                    BrandFiltro = null;
                }
            }
            else
            {
                MessageBox.Show("Debe actualizar la grilla!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GenerostoolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FiltrarOn)
            {
                if (GenerostoolStripComboBox.SelectedIndex > 0)
                {
                    FiltrarOn = true;
                    var servicio = _serviceProvider.GetService<IGenreServicio>();
                    GenreFiltro = servicio?.GetGenrePorNombre(GenerostoolStripComboBox.Text);

                    Cantregistros = _servicio.GetCantidad(g => g.genre == GenreFiltro);

                    paginas = FormHelper.CalcularPaginas(Cantregistros, cantidadPorPagina);
                    CantRegistrostextBox.Text = paginas.ToString();
                    CombosHelper.CargarCombosPaginas(paginas, ref PaginascomboBox);
                    listaShoe = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina, orden, BrandFiltro, GenreFiltro, SportFiltro);
                    MostrarDatosEnGrilla();
                    FltrarrtoolStripButton.BackColor = Color.Red;
                    FltrarrtoolStripButton.Enabled = false;
                }
                else
                {
                    BrandFiltro = null;
                }
            }
            else
            {
                MessageBox.Show("Debe actualizar la grilla!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeportestoolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FiltrarOn)
            {
                if (DeportestoolStripComboBox.SelectedIndex > 0)
                {
                    FiltrarOn = true;
                    var servicio = _serviceProvider.GetService<ISportServicio>();
                    SportFiltro = servicio?.GetSportPorNombre(DeportestoolStripComboBox.Text);

                    Cantregistros = _servicio.GetCantidad(s => s.sport == SportFiltro);

                    paginas = FormHelper.CalcularPaginas(Cantregistros, cantidadPorPagina);
                    CantRegistrostextBox.Text = paginas.ToString();
                    CombosHelper.CargarCombosPaginas(paginas, ref PaginascomboBox);
                    listaShoe = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina, orden, BrandFiltro, GenreFiltro, SportFiltro);
                    MostrarDatosEnGrilla();
                    FltrarrtoolStripButton.BackColor = Color.Red;
                    FltrarrtoolStripButton.Enabled = false;
                }
                else
                {
                    BrandFiltro = null;
                }
            }
            else
            {
                MessageBox.Show("Debe actualizar la grilla!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void BuscarMaryDeptoolStripButton_Click(object sender, EventArgs e)
        {
            FrmMarcaYDeporte frm = new FrmMarcaYDeporte(_serviceProvider)
            { Text = "Seleccionar Marca y Deporte" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                var Marca = frm.GetMarca();
                var Deporte = frm.GetDeporte();
                Func<Shoe, bool> predicado;
                if (Deporte == null)
                {
                    predicado = s => s.BrandId == Marca.BrandId;
                }
                else
                {
                    predicado = s => s.BrandId == Marca.BrandId && s.SportId == Deporte.SportId;
                }
                listaShoe = _servicio.FiltrarMarcaYDeporte(predicado);
                MostrarDatosEnGrilla();
                BuscarMaryDeptoolStripButton.BackColor = Color.Red;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GeneroYDeportetoolStripButton_Click(object sender, EventArgs e)
        {
            FrmGeneroYDeporte frm = new FrmGeneroYDeporte(_serviceProvider)
            { Text = "Seleccionar Genero y Deporte" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                var Genero = frm.GetGenero();
                var Deporte = frm.GetDeporte();
                Func<Shoe, bool> predicado;
                if (Deporte == null)
                {
                    predicado = s => s.GenreId == Genero.GenreId;
                }
                else
                {
                    predicado = s => s.GenreId == Genero.GenreId && s.SportId == Deporte.SportId;
                }
                listaShoe = _servicio.FiltrarGeneroYDeporte(predicado);
                MostrarDatosEnGrilla();
                GeneroYDeportetoolStripButton.BackColor = Color.Red;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ActualizartoolStripButton_Click_1(object sender, EventArgs e)
        {
            FiltrarOn = false;
            BrandFiltro = null;
            GenreFiltro = null;
            SportFiltro = null;
            BuscarMarcaEntreDosPreciostoolStripButton.BackColor = SystemColors.Control;
            BuscarMaryDeptoolStripButton.BackColor = SystemColors.Control;
            GeneroYDeportetoolStripButton.BackColor = SystemColors.Control;
            FltrarrtoolStripButton.Enabled = true;
            FltrarrtoolStripButton.BackColor = SystemColors.Control;

            RecargarGrilla();

        }

        private void BuscarMarcaEntreDosPreciostoolStripButton_Click(object sender, EventArgs e)
        {
            FrmMarcaEntreDosPrecios frm = new FrmMarcaEntreDosPrecios(_serviceProvider)
            { Text = " Marca Entre Dos Precios" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                var precioMin = frm.GetPrecioMinimo();
                var precioMax = frm.GetPrecioMaximo();
                var marca = frm.GetMarca();

                if (marca != null && precioMin <= precioMax)
                {
                    listaShoe = _servicio.BuscarMarcaEntreDosPrecios(marca, precioMin, precioMax);
                    MostrarDatosEnGrilla();
                    BuscarMarcaEntreDosPreciostoolStripButton.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show(@"Seleccionar la marca y el rango de precios",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void TallestoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosdataGridView.SelectedRows[0];
            if (r.Tag is not ShoeListDto shoeListDto)
            {
                return;
            }

            List<SizeStockDto>? talles = _servicio.GetSizePorShoes(shoeListDto.ShoeId);

            if (talles == null || talles.Count == 0)
            {
                MessageBox.Show("Zapato sin Talles asignados", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            
            FrmDetalleTalle frm = new FrmDetalleTalle()
            {
                Text = $"Talles del Zapato - {shoeListDto.Descripcion} - {shoeListDto.Model}"
            };

            frm.SetDatos(talles);
            frm.ShowDialog(this);
        }

        private void AsignarTalletoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            if (r.Tag is null)
            {
                return;
            }
            var Shoedto = (ShoeListDto)r.Tag;

            Shoe? shoe = _servicio.GetShoePorId(Shoedto?.ShoeId ?? 0);
            if (shoe is null)
            {
                return;
            }
            FrmAgregarTalle frm = new FrmAgregarTalle(_serviceProvider) { Text = "Agregar Talle" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Size? talle = frm.GetTalle();
                if (talle is null)
                {
                    return;
                }
                if (!_servicio.ExisteRelacion(shoe, talle))
                {
                    _servicio.AsignarTallesAZapato(shoe, talle);
                    if (Shoedto is not null)
                    {
                        Shoedto.QuantityInStock++;
                        GridHelper.SetearFila(r, Shoedto);
                    }
                    MessageBox.Show("Talle asignado al Zapato!", "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Asignacion Existente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarTalletoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            if (r.Tag is null)
            {
                return;
            }
            var Shoedto = (ShoeListDto)r.Tag;

            Shoe? shoe = _servicio.GetShoePorId(Shoedto?.ShoeId ?? 0);
            if (shoe is null)
            {
                return;
            }
            FrmEliminarTalle frm = new FrmEliminarTalle(_serviceProvider) { Text = "Eliminar Talle" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Size? talle = frm.GetTalle();
                if (talle is null)
                {
                    return;
                }
                if (_servicio.ExisteRelacion(shoe, talle))
                {
                    _servicio.EliminarTalleDeZapato(shoe, talle);
                    if (Shoedto is not null)
                    {
                        Shoedto.QuantityInStock--;
                        GridHelper.SetearFila(r, Shoedto);
                    }
                    MessageBox.Show("Talle eliminado del Zapato!", "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El zapato no tiene este talle asignado!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orden = Orden.AZ;
            MostrarZapatoOrdenado();
        }

        private void MostrarZapatoOrdenado()
        {
            listaShoe = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina, orden);
            MostrarDatosEnGrilla();
        }

        private void zAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orden = Orden.ZA;
            MostrarZapatoOrdenado();
        }

        private void menorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orden = Orden.MenorPrecio;
            MostrarZapatoOrdenado();

        }

        private void mayorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orden = Orden.MayorPrecio;
            MostrarZapatoOrdenado();

        }


    }
}
