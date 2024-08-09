using TPdeEFCore01.Windows.Helpers;

namespace TPdeEFCore01.Windows
{
    public partial class FrmAgregarStock : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public int CantidadStock { get; set; }
        public Entidades.Size? TalleSeleccionado { get; private set; }

        public FrmAgregarStock(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboTalles(_serviceProvider, ref TallescomboBox);
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                CantidadStock = int.Parse(StocktextBox.Text);
                TalleSeleccionado = ObtenerTalleSeleccionado();
                DialogResult = DialogResult.OK;
            }
        }

        private Entidades.Size? ObtenerTalleSeleccionado()
        {
            return TallescomboBox.SelectedItem as Entidades.Size;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(StocktextBox.Text, out int stock))
            {
                valido = false;
                errorProvider1.SetError(StocktextBox, "Stock no es valido");
            }
            if (TallescomboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(TallescomboBox, "Debe seleccionar un Talle");
            }
            return valido;
        }

        public Entidades.Size? GetTalle()
        {
            return TalleSeleccionado;
        }

        private void TallescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TallescomboBox.SelectedItem is not null)
            {
                TalleSeleccionado = TallescomboBox.SelectedIndex > 0 ? 
                    (Entidades.Size)TallescomboBox.SelectedItem : null;

            }
        }
    }
}
