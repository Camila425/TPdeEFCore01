using Microsoft.Extensions.DependencyInjection;
using TPdeEFCore01.Entidades;
using TPdeEFCore01.Servicios.Interfaces;
using TPdeEFCore01.Windows.Helpers;

namespace TPdeEFCore01.Windows
{
    public partial class FrmMarcaEntreDosPrecios : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private Brand? brand;
        private decimal precioMinimo;
        private decimal precioMaximo;
        public FrmMarcaEntreDosPrecios(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
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

            if (!decimal.TryParse(PrecioMinimotextBox.Text, out precioMinimo))
            {
                valido = false;
                errorProvider1.SetError(PrecioMinimotextBox, "Debe ingresar un numero valido para el precio minimo");
            }

            if (!decimal.TryParse(PrecioMaximotextBox.Text, out precioMaximo))
            {
                valido = false;
                errorProvider1.SetError(PrecioMaximotextBox, "Debe ingresar un numero valido para el precio maximo");
            }

            return valido;
        }

        private void FrmMarcaEntreDosPrecios_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboBrand(_serviceProvider, ref MarcacomboBox);
        }

        public Brand? GetMarca()
        {
            return brand;
        }

        public decimal GetPrecioMinimo()
        {
            return precioMinimo;
        }

        public decimal GetPrecioMaximo()
        {
            return precioMaximo;
        }

        private void MarcacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var servicio = _serviceProvider.GetService<IBrandServicio>();
            brand = servicio?.GetBrandPorNombre(MarcacomboBox.Text);
        }
    }
}
