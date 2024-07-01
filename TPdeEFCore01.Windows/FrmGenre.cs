using TPdeEFCore01.Entidades;
using TPdeEFCore01.Servicios.Interfaces;
using TPdeEFCore01.Windows.Helpers;

namespace TPdeEFCore01.Windows
{
    public partial class FrmGenre : Form
    {
        private readonly IGenreServicio _servicio;
        private List<Genre>? lista;
        //paginacion
        private int cantidadPorPagina = 2;
        private int Cantregistros;
        private int paginas;
        private int paginaActual = 0;
        public FrmGenre(IGenreServicio servicio)
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
                foreach (var genre in lista)
                {
                    DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                    GridHelper.SetearFila(r, genre);
                    GridHelper.AgregarFila(r, DatosdataGridView);
                }

            }
        }

        private void FrmGenre_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void NuevotoolStripButton_Click(object sender, EventArgs e)
        {
            FrmGenreAE frm = new FrmGenreAE() { Text = "Agregar un Nuevo Genero" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Genre? genre = frm.GetGenre();

                if (genre is not null)
                {
                    if (!_servicio.Existe(genre))
                    {
                        _servicio.Guardar(genre);
                        var r = GridHelper.ConstruirFila(DatosdataGridView);
                        GridHelper.SetearFila(r, genre);
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
            Genre? genre = (Genre)r.Tag;
            FrmGenreAE frm = new FrmGenreAE() { Text = "Editar un Nuevo Genero" };
            frm.SetGenre(genre);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                genre = frm.GetGenre();
                if (genre is not null)
                {
                    if (!_servicio.Existe(genre))
                    {
                        _servicio.Guardar(genre);
                        GridHelper.SetearFila(r, genre);
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
                Genre genre = (Genre)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja a {genre.GenreName}?",
                    "Mensaje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                try
                {

                    if (!_servicio.EstaRelacionado(genre))
                    {
                        _servicio.Borrar(genre);
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

        private void SalirtoolStripButton_Click_1(object sender, EventArgs e)
        {
            Close();
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
