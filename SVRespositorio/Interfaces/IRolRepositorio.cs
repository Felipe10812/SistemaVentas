using SVRespositorio.Entities;

namespace SVRespositorio.Interfaces
{
    public interface IRolRepositorio
    {
        Task<List<Rol>> Lista();
    }
}