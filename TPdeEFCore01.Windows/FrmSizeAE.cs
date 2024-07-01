using Size = TPdeEFCore01.Entidades.Size;

namespace TPdeEFCore01.Windows
{
    public partial class FrmSizeAE : Form
    {
        private Size? size;

        public FrmSizeAE()
        {
            InitializeComponent();
        }

        public Size? GetSize()
        {
            return size;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (size != null)
            {
                TalletextBox.Text = size.SizeNumber.ToString();
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (size == null)
                {
                    size = new Size();

                }
                size.SizeNumber = decimal.Parse(TalletextBox.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!decimal.TryParse(TalletextBox.Text, out decimal tallle))
            {
                valido = false;
                errorProvider1.SetError(TalletextBox, "Talle del Zapato No es Valido!");
            }
            return valido;
        }

        public void SetSize(Size size)
        {
            this.size = size;
        }
    }
}
