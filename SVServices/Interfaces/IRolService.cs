using SVRespositorio.Entities;

namespace SVServices.Interfaces
{
    public interface IRolService
    {
        Task<List<Rol>> Lista();
    }
}