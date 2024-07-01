using TPdeEFCore01.Entidades;
using TPdeEFCore01.Windows.Helpers;

namespace TPdeEFCore01.Windows
{
    public partial class FrmMarcaYDeporte : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private Brand? Brand;
        private Sport? Sport;
        public FrmMarcaYDeporte(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        public Sport? GetDeporte()
        {
            return Sport;
        }

        public Brand? GetMarca()
        {
            return Brand;
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
            if (MarcacomboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(MarcacomboBox, "Debe seleccionar una Marca");
            }
            if (DeportecomboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(DeportecomboBox, "Debe seleccionar un Deporte");
            }
            return valido;
        }

        private void FrmMarcaYDeporte_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboBrand(_serviceProvider, ref MarcacomboBox);
        }

        private void MarcacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MarcacomboBox.SelectedIndex > 0)
            {
                var seleccionarMarca = (Brand)MarcacomboBox.SelectedItem;
                Brand = seleccionarMarca;
                CombosHelper.CargarComboMarcaYDeporte(_serviceProvider, ref DeportecomboBox, seleccionarMarca);
            }
            else
            {
                Brand = null;
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
