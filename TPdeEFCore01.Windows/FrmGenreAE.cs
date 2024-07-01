using TPdeEFCore01.Entidades;

namespace TPdeEFCore01.Windows
{
    public partial class FrmGenreAE : Form
    {
        private Genre? genre;
        public FrmGenreAE()
        {
            InitializeComponent();
        }

        public Genre? GetGenre()
        {
            return genre;
        }

        public void SetGenre(Genre genre)
        {
            this.genre = genre;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (genre != null)
            {
                GenretextBox.Text = genre.GenreName;
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (genre == null)
                {
                    genre = new Genre();

                }
                genre.GenreName = GenretextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(GenretextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(GenretextBox, "Nombre del Genero No es Valido!");
            }
            return valido;
        }
    }
}
