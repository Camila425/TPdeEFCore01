using TPdeEFCore01.Entidades;
using TPdeEFCore01.Servicios.Interfaces;
using TPdeEFCore01.Windows.Helpers;

namespace TPdeEFCore01.Windows
{
    public partial class FrmSports : Form
    {
        private readonly ISportServicio _servicio;
        private List<Sport>? lista;
        //paginacion
        private int cantidadPorPagina = 10;
        private int Cantregistros;
        private int paginas;
        private int paginaActual = 0;
        public FrmSports(ISportServicio servicio)
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

        private void FrmSports_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void NuevotoolStripButton_Click(object sender, EventArgs e)
        {
            FrmSportAE frm = new FrmSportAE() { Text = "Agregar un Nuevo Deporte" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Sport? sport = frm.GetSport();

                if (sport is not null)
                {
                    if (!_servicio.Existe(sport))
                    {
                        _servicio.Guardar(sport);
                        var r = GridHelper.ConstruirFila(DatosdataGridView);
                        GridHelper.SetearFila(r, sport);
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
            Sport? sport = (Sport)r.Tag;
            FrmSportAE frm = new FrmSportAE() { Text = "Editar un Deporte" };
            frm.SetSport(sport);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                sport = frm.GetSport();
                if (sport is not null)
                {
                    if (!_servicio.Existe(sport))
                    {
                        _servicio.Guardar(sport);
                        GridHelper.SetearFila(r, sport);
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

        private void BorrartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            if (r.Tag is not null)
            {
                Sport sport = (Sport)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja a {sport.SportName}?",
                    "Mensaje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                try
                {
                    if (!_servicio.EstaRelacionado(sport))
                    {
                        _servicio.Borrar(sport);
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
