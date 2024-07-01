using TPdeEFCore01.Servicios.Interfaces;
using TPdeEFCore01.Windows.Helpers;
using Color = TPdeEFCore01.Entidades.Color;

namespace TPdeEFCore01.Windows
{
    public partial class FrmColors : Form
    {
        private readonly IColorServicio _servicio;
        private List<Color>? lista;
        //paginacion
        private int cantidadPorPagina = 10;
        private int Cantregistros;
        private int paginas;
        private int paginaActual = 0;
        public FrmColors(IColorServicio servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }

        private void SalirtoolStripButton_Click(object sender, EventArgs e)
        {
            Close();
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

        private void FrmColors_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void NuevotoolStripButton_Click(object sender, EventArgs e)
        {
            FrmColorAE frm = new FrmColorAE() { Text = "Agregar un Nuevo Color" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Color? color = frm.GetColor();

                if (color is not null)
                {
                    if (!_servicio.Existe(color))
                    {
                        _servicio.Guardar(color);
                        var r = GridHelper.ConstruirFila(DatosdataGridView);
                        GridHelper.SetearFila(r, color);
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
            Color? color = (Color)r.Tag;
            FrmColorAE frm = new FrmColorAE() { Text = "Editar un Color" };
            frm.SetColor(color);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                color = frm.GetColor();
                if (color is not null)
                {
                    if (!_servicio.Existe(color))
                    {
                        _servicio.Guardar(color);
                        GridHelper.SetearFila(r, color);
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
                Color color = (Color)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja a {color.ColorName}?",
                    "Mensaje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                try
                {

                    if (!_servicio.EstaRelacionado(color))
                    {
                        _servicio.Borrar(color);
                        GridHelper.QuitarFila(r, DatosdataGridView);
                        MessageBox.Show("Registro Borrado!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
