using Color = TPdeEFCore01.Entidades.Color;

namespace TPdeEFCore01.Windows
{
    public partial class FrmColorAE : Form
    {
        private Color? color;
        public FrmColorAE()
        {
            InitializeComponent();
        }

        public Color? GetColor()
        {
            return color;
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (color != null)
            {
                ColortextBox.Text = color.ColorName;
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (color == null)
                {
                    color = new Color();

                }
                color.ColorName = ColortextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ColortextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(ColortextBox, "Nombre del Color No es Valido!");
            }
            return valido;
        }
    }
}
