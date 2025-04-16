using SVRespositorio.Entities;
using SVRespositorio.Interfaces;
using SVServices.Interfaces;

namespace SVServices.Implementacion
{
    public class NegocioService : INegocioService
    {
        private readonly INegocioRepositorio _negocioRepositorio;
        public NegocioService(INegocioRepositorio negocioRepositorio)
        {
            _negocioRepositorio = negocioRepositorio;
        }

        public async Task<Negocio> Obtener()
        {
            return await _negocioRepositorio.Obtener();
        }

        public async Task Editar(Negocio negocio)
        {
            await _negocioRepositorio.Editar(negocio);
        }
    }
}