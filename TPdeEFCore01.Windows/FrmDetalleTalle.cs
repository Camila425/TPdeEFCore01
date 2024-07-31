using TPdeEFCore01.Entidades;
using TPdeEFCore01.Windows.Helpers;

namespace TPdeEFCore01.Windows
{
    public partial class FrmDetalleTalle : Form
    {
        private List<SizeStockDto>? Talles;

        public FrmDetalleTalle()
        {
            InitializeComponent();
        }

        public void SetDatos(List<SizeStockDto> talles)
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
