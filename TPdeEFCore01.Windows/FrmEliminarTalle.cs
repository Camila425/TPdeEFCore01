using TPdeEFCore01.Windows.Helpers;
using Size = TPdeEFCore01.Entidades.Size;

namespace TPdeEFCore01.Windows
{
    public partial class FrmEliminarTalle : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private Size? TalleSeleccionado;


        public FrmEliminarTalle(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        public Size? GetTalle()
        {
            return TalleSeleccionado;
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
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboTalles(_serviceProvider, ref TallesComboBox);
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (TallesComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(TallesComboBox, "Debe seleccionar un Talle");
            }
            return valido;
        }

        private void TallesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TallesComboBox.SelectedItem is not null)
            {
                TalleSeleccionado = TallesComboBox.SelectedIndex > 0 ? (Size)TallesComboBox.SelectedItem : null;
            }
        }
    }
}
