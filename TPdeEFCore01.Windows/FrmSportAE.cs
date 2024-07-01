using TPdeEFCore01.Entidades;

namespace TPdeEFCore01.Windows
{
    public partial class FrmSportAE : Form
    {
        private Sport? sport;
        public FrmSportAE()
        {
            InitializeComponent();
        }

        public Sport? GetSport()
        {
            return sport;
        }

        public void SetSport(Sport sport)
        {
            this.sport = sport;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (sport != null)
            {
                SporttextBox.Text = sport.SportName;
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (sport == null)
                {
                    sport = new Sport();

                }
                sport.SportName = SporttextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(SporttextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(SporttextBox, "Nombre del Deporte No es Valido!");
            }
            return valido;
        }
    }
}
