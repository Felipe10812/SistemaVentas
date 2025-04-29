using SVRespositorio.Entities;
using SVRespositorio.Interfaces;
using SVServices.Interfaces;

namespace SVServices.Implementacion
{
    public class RolService : IRolService
    {
        private readonly IRolRepositorio _rolRepositorio;
        public RolService(IRolRepositorio rolRepositorio)
        {
            _rolRepositorio = rolRepositorio;
        }

        public async Task<List<Rol>> Lista()
        {
            return await _rolRepositorio.Lista();
        }
    }
}