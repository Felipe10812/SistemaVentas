using SVRespositorio.Entities;
using SVRespositorio.Interfaces;
using SVServices.Interfaces;

namespace SVServices.Implementacion
{
    public class MedidaService : IMedidaService
    {
        private readonly IMedidaRepositorio _medidaRespositorio;

        public MedidaService(IMedidaRepositorio medidaRepository)
        {
            _medidaRespositorio = medidaRepository;
        }

        public async Task<List<Medida>> Lista()
        {
            return await _medidaRespositorio.Lista();
        }

        public IEnumerable<object> ObtenerMedidas()
        {
            // Implementación de ejemplo
            return new List<object>();
        }
    }
}