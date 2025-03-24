using SVRespositorio.Entities;

namespace SVServices.Interfaces
{
    public interface IMedidaService
    {
        Task<List<Medida>> Lista();
        IEnumerable<object> ObtenerMedidas();
    }
}