using TPdeEFCore01.Entidades;
using TPdeEFCore01.Windows.Helpers;
using Color = TPdeEFCore01.Entidades.Color;

namespace TPdeEFCore01.Windows
{
    public partial class FrmShoeAE : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private Shoe? Shoe;
        private Brand? brand;
        private Genre? Genre;
        private Sport? Sport;
        private Color? color;

        public FrmShoeAE(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        public Shoe? GetShoe()
        {
            return Shoe;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboBrand(_serviceProvider, ref MarcacomboBox);
            CombosHelper.CargarComboGenre(_serviceProvider, ref GenerocomboBox);
            CombosHelper.CargarComboSport(_serviceProvider, ref DeportecomboBox);
            CombosHelper.CargarComboColor(_serviceProvider, ref ColorcomboBox);
            if (Shoe != null)
            {
                DescripciontextBox.Text = Shoe.Description;
                ModelotextBox.Text = Shoe.Model;
                PreciotextBox.Text = Shoe.Price.ToString();

                MarcacomboBox.SelectedValue = Shoe.BrandId;
                brand = Shoe.brand;

                GenerocomboBox.SelectedValue = Shoe.GenreId;
                Genre = Shoe.genre;

                DeportecomboBox.SelectedValue = Shoe.SportId;
                Sport = Shoe.sport;

                ColorcomboBox.SelectedValue = Shoe.ColorId;
                color = Shoe.color;
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                if (Shoe == null)
                {
                    Shoe = new Shoe();
                }
                Shoe.Description = DescripciontextBox.Text;
                Shoe.Model = ModelotextBox.Text;
                Shoe.Price = decimal.Parse(PreciotextBox.Text);
                Shoe.brand = brand;
                Shoe.genre = Genre;
                Shoe.sport = Sport;
                Shoe.color = color;
                Shoe.BrandId = brand.BrandId;
                Shoe.GenreId = Genre.GenreId;
                Shoe.SportId = Sport.SportId;
                Shoe.ColorId = color.ColorId;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(DescripciontextBox.Text) || string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(DescripciontextBox, "Nombre de la Descripcion No es Valido");
            }
            if (string.IsNullOrEmpty(ModelotextBox.Text) || string.IsNullOrWhiteSpace(ModelotextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(DescripciontextBox, "Nombre del Modelo No es Valido");
            }
            if (!decimal.TryParse(PreciotextBox.Text, out decimal Precio) || (Precio <= 0))
            {
                valido = false;
                errorProvider1.SetError(PreciotextBox, "Precio no es valido o mal ingresado");
            }
            if (MarcacomboBox.SelectedIndex == 0 && brand == null)
            {
                valido = false;
                errorProvider1.SetError(MarcacomboBox, "Debe seleccionar una marca");
            }
            if (GenerocomboBox.SelectedIndex == 0 && Genre == null)
            {
                valido = false;
                errorProvider1.SetError(GenerocomboBox, "Debe seleccionar un Genero");
            }
            if (DeportecomboBox.SelectedIndex == 0 && Sport == null)
            {
                valido = false;
                errorProvider1.SetError(DeportecomboBox, "Debe seleccionar un Deporte");
            }
            if (ColorcomboBox.SelectedIndex == 0 && color == null)
            {
                valido = false;
                errorProvider1.SetError(ColorcomboBox, "Debe seleccionar un Color");
            }
            return valido;
        }

        private void AgregarNuevaMarcabutton_Click(object sender, EventArgs e)
        {
            FrmBrandAE frm = new FrmBrandAE();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            brand = frm.GetBrand();

            MarcacomboBox.Enabled = false;
            NuevaMarcaabel.Visible = true;
        }

        private void AgregarUnNuevoGenerobutton_Click(object sender, EventArgs e)
        {
            FrmGenreAE frm = new FrmGenreAE();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Genre = frm.GetGenre();

            GenerocomboBox.Enabled = false;
            NuevoGenerolabel.Visible = true;
        }

        private void AgregarUnNuevoDeportebutton_Click(object sender, EventArgs e)
        {
            FrmSportAE frm = new FrmSportAE();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Sport = frm.GetSport();

            DeportecomboBox.Enabled = false;
            NuevoDeportelabel.Visible = true;
        }

        private void AgregarUnNuevoColorbutton_Click(object sender, EventArgs e)
        {
            FrmColorAE frm = new FrmColorAE();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            color = frm.GetColor();

            ColorcomboBox.Enabled = false;
            NuevoColorlabel.Visible = true;
        }

        private void MarcacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MarcacomboBox.SelectedIndex > 0)
            {
                brand = (Brand)MarcacomboBox.SelectedItem;
            }
            else
            {
                brand = null;
            }
        }

        private void GenerocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GenerocomboBox.SelectedIndex > 0)
            {
                Genre = (Genre)GenerocomboBox.SelectedItem;
            }
            else
            {
                Genre = null;
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

        private void ColorcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColorcomboBox.SelectedIndex > 0)
            {
                color = (Color)ColorcomboBox.SelectedItem;
            }
            else
            {
                color = null;
            }

        }

        public void SetShoe(Shoe? shoe)
        {
            this.Shoe = shoe;
        }
    }
}
