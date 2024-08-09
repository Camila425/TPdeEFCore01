using FontAwesome.Sharp;
using Microsoft.Extensions.DependencyInjection;
using TPdeEFCore01.Servicios.Interfaces;

namespace TPdeEFCore01.Windows
{
    public partial class FrmPrincipal : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private IconMenuItem menuActivo = null;
        private Form formularioActivo = null;

        public FrmPrincipal(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

            this.Resize += FrmPrincipal_Resize;
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            pictureBox1.Visible = false;
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            formularioActivo = formulario;

            Contenedorpanel.Controls.Add(formulario);
            formulario.Show();

            formularioActivo.Dock = DockStyle.Fill;
        }

        private void FrmPrincipal_Resize(object sender, EventArgs e)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Size = Contenedorpanel.ClientSize;
            }
        }

        private void MarcasiconMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmBrands(_serviceProvider.GetService<IBrandServicio>()));
        }

        private void GenerosiconMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmGenre(_serviceProvider.GetService<IGenreServicio>()));
        }

        private void DeportesiconMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmSports(_serviceProvider.GetService<ISportServicio>()));
        }

        private void ColoresiconMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmColors(_serviceProvider.GetService<IColorServicio>()));
        }

        private void ZapatosiconMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender,
                new FrmShoes(_serviceProvider.GetService<IShoeServicio>()
                , _serviceProvider));
        }

        private void TallesiconMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmSize(_serviceProvider.GetService<ISizeServicio>()));
        }

        private void SaliriconMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
