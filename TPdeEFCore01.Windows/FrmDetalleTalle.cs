using TPdeEFCore01.Windows.Helpers;
using Size = TPdeEFCore01.Entidades.Size;

namespace TPdeEFCore01.Windows
{
    public partial class FrmDetalleTalle : Form
    {
        private List<Size>? Talles;

        public FrmDetalleTalle()
        {
            InitializeComponent();
        }

        public void SetDatos(List<Size> talles)
        {
            this.Talles = talles;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Talles != null)
            {
                GridHelper.MostrarDatosEnGrilla(Talles, DatosdataGridView);
            }
        }
    }
}
