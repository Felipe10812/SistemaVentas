using SVPresentacion.Utilidades;
using SVRespositorio.Entities;
using SVServices.Interfaces;

namespace SVPresentacion.Formularios
{
    public partial class frmNegocio : Form
    {
        private readonly INegocioService _negocioService;
        private readonly ICloudinaryService _cloudinaryService;
        OpenFileDialog _openFileDialog = new OpenFileDialog();
        Negocio _negocio = new Negocio();

        public frmNegocio(INegocioService negocioService, ICloudinaryService cloudinaryService)
        {
            InitializeComponent();
            _negocioService = negocioService;
            _cloudinaryService = cloudinaryService;
        }

        private async void frmNegocio_Load(object sender, EventArgs e)
        {
            this.BackColor = AppColors.AzulMedio;
            await CargarDatos();
        }

        private async Task CargarDatos()
        {
            _openFileDialog.Filter = "Escoger imagen (*.jpg, *.png)|*.jpg;*.png";
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            _negocio = await _negocioService.Obtener();
            txbRazonSocial.Text = _negocio.RazonSocial;
            txbRFC.Text = _negocio.RFC;
            txbDireccion.Text = _negocio.Direccion;
            txbCelular.Text = _negocio.Celular;
            txbCorreo.Text = _negocio.Correo;
            txbSimboloMoneda.Text = _negocio.SimboloMoneda;
            if (_negocio.URLLogo != "")
            {
                pbLogo.ImageLocation = _negocio.URLLogo;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _openFileDialog.OpenFile();
                pbLogo.Image = Image.FromFile(_openFileDialog.FileName);

                txbRutaImagen.Text = _openFileDialog.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}