using TPdeEFCore01.Entidades;

namespace TPdeEFCore01.Windows
{
    public partial class FrmBrandAE : Form
    {
        private Brand? Brand;
        public FrmBrandAE()
        {
            InitializeComponent();
        }

        public Brand? GetBrand()
        {
            return Brand;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Brand != null)
            {
                MarcatextBox.Text = Brand.BrandName;
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (Brand == null)
                {
                    Brand = new Brand();

                }
                Brand.BrandName = MarcatextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(MarcatextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(MarcatextBox, "Nombre de Marca No es Valido!");
            }
            return valido;
        }

        public void SetBrand(Brand marca)
        {
            this.Brand = marca;
        }
    }
}
