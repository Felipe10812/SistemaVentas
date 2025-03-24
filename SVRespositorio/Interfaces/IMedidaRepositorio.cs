using SVRespositorio.Entities;

namespace SVRespositorio.Interfaces
{
    public interface IMedidaRepositorio
    {
        Task<List<Medida>> Lista();
    }
}