using SVPresentacion.Utilidades;
using SVPresentacion.ViewModels;
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

        private async Task MostrarCategorias(string buscar = "")
        {
            var listacategoria = await _categoriaService.Lista(buscar);

            var listaVM = listacategoria.Select(x => new CategoriaVM
            {
                IdCategoria = x.IdCategoria,
                Nombre = x.Nombre,
                IdMedida = x.RefIdMedida.IdMedida,
                Medida = x.RefIdMedida.Nombre,
                Activo = x.Activo,
                Habilitado = x.Activo ? "Si" : "No"

            }).ToList();

            dgvCategorias.DataSource = listaVM;

            dgvCategorias.Columns["IdCategoria"].Visible = false;
            dgvCategorias.Columns["IdMedida"].Visible = false;
            dgvCategorias.Columns["Activo"].Visible = false;
        }
        private async void frmCategoria_Load(object sender, EventArgs e)
        {
            await MostrarCategorias();
            dgvCategorias.ImplementarConfiguracion("Editar");

            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}