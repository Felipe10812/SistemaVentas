//using CloudinaryDotNet;
using Microsoft.Extensions.Configuration;
using SVServices.Interfaces;
using SVServices.Recursos.Cloudinary;
using System.Net;

namespace SVServices.Implementacion
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly IConfiguration _configuracion;
        //private readonly Cloudinary _cloudinary;

        public CloudinaryService(IConfiguration configuration)
        {
            _configuracion = configuration;

            var CloudName = _configuracion["Cloudinary:CloudName"];
            var ApiKey = _configuracion["Cloudinary:ApiKey"];
            var ApiSecret = _configuracion["Cloudinary:ApiSecret"];

            //_cloudinary = new Cloudinary(new Account(CloudName, ApiKey, ApiSecret));
        }

        public async Task<CloudinaryResponse> SubirImagen(string nombreImagen, Stream formatoImagen)
        {
            //var cloudinaryResponse = new CloudinaryResponse();
            //var uploadParams = new ImageUploadParams()
            //{
            //    //File = new FileDescription(nombreImagen, formatoImagen), 
            //    AssetFolder = "SistemaVenta"
            //};

            ////var UploadResult = await _cloudinary.UploadAsync(uploadParams);

            //if (UploadResult.StatusCode == HttpStatusCode.OK)
            //{
            //    cloudinaryResponse.PublicId = uploadParams.PublicId;
            //    cloudinaryResponse.SecureUrl = uploadParams.SecureUrl.ToString();
            //}
            //else
            //{
            //    cloudinaryResponse.PublicId = "";
            //}
            throw new NotImplementedException();

        }

        public async Task<bool> EliminarImagen(string publicId)
        {
            //var deleteParams = new DeletionParams(publicId);
            //var deleteResult = await _cloudinary.DestroyAsync(deleteParams);

            //if (deleteResult.StatusCode == HttpStatusCode.OK)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            throw new NotImplementedException();

        }
    }
}