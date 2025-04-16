using SVPresentacion.Utilidades;
using SVRespositorio.Entities;
using SVServices.Interfaces;
using SVServices.Recursos.Cloudinary;

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
            _openFileDialog.Filter = "Escoger imagen (*.jpg, *.png) | *.jpg;*.png";
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

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CloudinaryResponse cloudinaryResponse = new CloudinaryResponse();
                Negocio negocio = new Negocio();
                if (_openFileDialog.FileName != "")
                {
                    cloudinaryResponse = await _cloudinaryService.SubirImagen(_openFileDialog.SafeFileName, _openFileDialog.OpenFile());
                    if (cloudinaryResponse.PublicId != "")
                    {
                        if (_negocio.NombreLogo != "")
                            await _cloudinaryService.EliminarImagen(_negocio.NombreLogo);
                        negocio.NombreLogo = cloudinaryResponse.PublicId;
                        negocio.URLLogo = cloudinaryResponse.SecureUrl;

                        _negocio.NombreLogo = cloudinaryResponse.PublicId;
                        _negocio.URLLogo = cloudinaryResponse.SecureUrl;
                    }
                }
                else
                {
                    negocio.NombreLogo = _negocio.NombreLogo;
                    negocio.URLLogo = _negocio.URLLogo;
                }

                negocio.RazonSocial = txbRazonSocial.Text;
                negocio.RFC = txbRFC.Text;
                negocio.Direccion = txbDireccion.Text;
                negocio.Celular = txbCelular.Text;
                negocio.Correo = txbCorreo.Text;
                negocio.SimboloMoneda = txbSimboloMoneda.Text;

                await _negocioService.Editar(negocio);

                MessageBox.Show("Negocio guardado correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbRutaImagen.Text = "";
                _openFileDialog = new OpenFileDialog();
                _openFileDialog.Filter = "Escoger imagen (*.jpg, *.png) | *.jpg;*.png";
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado al guardar el negocio. Intente nuevamente.",
                                "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}