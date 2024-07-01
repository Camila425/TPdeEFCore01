using TPdeEFCore01.Entidades.Enums;
using TPdeEFCore01.Servicios.Interfaces;
using TPdeEFCore01.Windows.Helpers;
using Size = TPdeEFCore01.Entidades.Size;

namespace TPdeEFCore01.Windows
{
    public partial class FrmSize : Form
    {
        private readonly ISizeServicio _servicio;
        private List<Size>? listaSize;
        //paginacion
        private int cantidadPorPagina = 5;
        private int Cantregistros;
        private int paginas;
        private int paginaActual = 0;
        public FrmSize(ISizeServicio servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }

        private void FrmSize_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {

                Cantregistros = _servicio.GetCantidad();
                paginas = FormHelper.CalcularPaginas(Cantregistros, cantidadPorPagina);
                CantRegistrostextBox.Text = paginas.ToString();
                CombosHelper.CargarCombosPaginas(paginas, ref PaginascomboBox);
                listaSize = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina);
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
            if (listaSize is not null)
            {
                foreach (var item in listaSize)
                {
                    DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                    GridHelper.SetearFila(r, item);
                    GridHelper.AgregarFila(r, DatosdataGridView);
                }

            }
        }

        private void Primerobutton_Click(object sender, EventArgs e)
        {
            paginaActual = 0;
            PaginascomboBox.SelectedIndex = paginaActual;
            listaSize = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina, orden);
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
            listaSize = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina, orden);
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
            listaSize = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina, orden);
            MostrarDatosEnGrilla();
        }

        private void Ultimobutton_Click(object sender, EventArgs e)
        {
            paginaActual = paginas - 1;
            PaginascomboBox.SelectedIndex = paginaActual;
            listaSize = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina, orden);
            MostrarDatosEnGrilla();
        }

        private void NuevotoolStripButton_Click(object sender, EventArgs e)
        {
            FrmSizeAE frm = new FrmSizeAE() { Text = "Agregar un Nuevo Talle" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Size? size = frm.GetSize();

                if (size is not null)
                {
                    if (!_servicio.Existe(size))
                    {
                        _servicio.Guardar(size);
                        var r = GridHelper.ConstruirFila(DatosdataGridView);
                        GridHelper.SetearFila(r, size);
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

        private void BorrartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            if (r.Tag is not null)
            {
                Size size = (Size)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja a {size.SizeNumber}?", "Mensaje", 
                    MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                try
                {

                    if (!_servicio.EstaRelacionado(size))
                    {
                        _servicio.Borrar(size);
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
            Size? size = (Size)r.Tag;
            FrmSizeAE frm = new FrmSizeAE() { Text = "Editar un Talle" };
            frm.SetSize(size);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                size = frm.GetSize();
                if (size is not null)
                {
                    if (!_servicio.Existe(size))
                    {
                        _servicio.Guardar(size);
                        GridHelper.SetearFila(r, size);
                        MessageBox.Show("Registro Editado!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private Orden orden = Orden.SinOrden;
        private void MenorTalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orden = Orden.MenorTalle;
            MostrarOrdenadoPorTalle(orden);
        }

        private void MostrarOrdenadoPorTalle(Orden orden)
        {
            listaSize = _servicio.GetListaPaginada(paginaActual, cantidadPorPagina, orden);
            MostrarDatosEnGrilla();
        }

        private void MayorTalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orden = Orden.MayorTalle;
            MostrarOrdenadoPorTalle(orden);
        }

        private void ActualizartoolStripButton_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }
    }
}
