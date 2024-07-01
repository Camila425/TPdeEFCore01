using TPdeEFCore01.Entidades;
using TPdeEFCore01.Windows.Helpers;

namespace TPdeEFCore01.Windows
{
    public partial class FrmGeneroYDeporte : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private Genre? genre;
        private Sport? Sport;
        public FrmGeneroYDeporte(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        public Sport GetDeporte()
        {
            return Sport;
        }

        public Genre GetGenero()
        {
            return genre;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (GenerocomboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(GenerocomboBox, "Debe seleccionar un Genero");
            }
            if (DeportecomboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(DeportecomboBox, "Debe seleccionar un Deporte");
            }
            return valido;
        }

        private void FrmGeneroYDeporte_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboGenre(_serviceProvider, ref GenerocomboBox);

        }

        private void GenerocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GenerocomboBox.SelectedIndex > 0)
            {
                var seleccionarGenero = (Genre)GenerocomboBox.SelectedItem;
                genre = seleccionarGenero;
                CombosHelper.CargarComboGeneroYDeporte(_serviceProvider, ref DeportecomboBox, seleccionarGenero);
            }
            else
            {
                genre = null;
                DeportecomboBox.DataSource = null;
            }
        }

        private void DeportecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeportecomboBox.SelectedIndex > 0)
            {
                Sport = (Sport)DeportecomboBox.SelectedItem;
            }
            else
            {
                Sport = null;
            }
        }
    }
}
