using TPdeEFCore01.Entidades;
using TPdeEFCore01.Servicios.Interfaces;
using TPdeEFCore01.Windows.Helpers;

namespace TPdeEFCore01.Windows
{
    public partial class FrmBrands : Form
    {
        private readonly IBrandServicio _servicio;
        private List<Brand>? lista;
        //paginacion
        private int cantidadPorPagina = 5;
        private int Cantregistros;
        private int paginas;
        private int paginaActual=0;
        public FrmBrands(IBrandServicio servicio)
        {
            InitializeComponent();
            _servicio = servicio;
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
                lista = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina);
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
            if (lista is not null)
            {
                foreach (var item in lista)
                {
                    DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                    GridHelper.SetearFila(r, item);
                    GridHelper.AgregarFila(r, DatosdataGridView);
                }

            }
        }

        private void FrmBrands_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void NuevotoolStripButton_Click(object sender, EventArgs e)
        {
            FrmBrandAE frm = new FrmBrandAE() { Text = "Agregar una  Nueva Marca" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Brand? brand = frm.GetBrand();

                if (brand is not null)
                {
                    if (!_servicio.Existe(brand))
                    {
                        _servicio.Guardar(brand);
                        var r = GridHelper.ConstruirFila(DatosdataGridView);
                        GridHelper.SetearFila(r, brand);
                        GridHelper.AgregarFila(r, DatosdataGridView);
                        MessageBox.Show("Registro Agregado!!", "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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

        private void EditartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            if (r.Tag == null)
            {
                return;
            }
            Brand? brand = (Brand)r.Tag;
            FrmBrandAE frm = new FrmBrandAE() { Text = "Editar una Marca" };
            frm.SetBrand(brand);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                brand = frm.GetBrand();
                if (brand is not null)
                {
                    if (!_servicio.Existe(brand))
                    {
                        _servicio.Guardar(brand);
                        GridHelper.SetearFila(r, brand);
                        MessageBox.Show("Registro Editado!!", "Mensaje", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro duplicado!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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
            var r = DatosdataGridView.SelectedRows[0];
            if (r.Tag is not null)
            {
                Brand brand = (Brand)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja a {brand.BrandName}?",
                    "Mensaje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                try
                {

                    if (!_servicio.EstaRelacionado(brand))
                    {
                        _servicio.Borrar(brand);
                        GridHelper.QuitarFila(r, DatosdataGridView);
                        MessageBox.Show("Registro Borrado!!", "Mensaje", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro Esta Relacionado", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Primerobutton_Click(object sender, EventArgs e)
        {
            paginaActual = 0;
            PaginascomboBox.SelectedIndex = paginaActual;
            lista = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina);
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
            lista = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina);
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
            lista = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina);
            MostrarDatosEnGrilla();
        }

        private void Ultimobutton_Click(object sender, EventArgs e)
        {
            paginaActual = paginas - 1;
            PaginascomboBox.SelectedIndex = paginaActual;
            lista = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina);
            MostrarDatosEnGrilla();
        }

        private void PaginascomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            paginaActual = PaginascomboBox.SelectedIndex;
            lista = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina);
            MostrarDatosEnGrilla();
       
        }
    }
}
