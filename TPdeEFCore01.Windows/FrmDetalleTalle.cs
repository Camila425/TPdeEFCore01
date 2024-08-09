using TPdeEFCore01.Entidades;
using TPdeEFCore01.Servicios.Interfaces;
using TPdeEFCore01.Windows.Helpers;

namespace TPdeEFCore01.Windows
{
    public partial class FrmDetalleTalle : Form
    {
        private List<SizeStockDto>? Talles;
        private readonly IShoeServicio _servicio;

        private readonly IServiceProvider _serviceProvider;
        public FrmDetalleTalle(IShoeServicio servicio, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _servicio = servicio;
            _serviceProvider = serviceProvider;
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
