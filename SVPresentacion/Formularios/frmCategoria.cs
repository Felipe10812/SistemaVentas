using SVServices.Interfaces;

namespace SVPresentacion.Formularios
{
    public partial class frmCategoria : Form
    {
        private readonly IMedidaService _medidaService;
        private readonly ICategoriaService _categoriaService;

        public frmCategoria(ICategoriaService categoriaService, IMedidaService medidaService)
        {
            InitializeComponent();
            _categoriaService = categoriaService;
            _medidaService = medidaService;
        }

        private async void frmCategoria_Load(object sender, EventArgs e)
        {
            var listacategoria = await _categoriaService.Lista("");
            dgvCategorias.DataSource = listacategoria;
        }
    }
}
