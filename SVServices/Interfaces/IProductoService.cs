using SVRespositorio.Entities;

namespace SVServices.Interfaces
{
    public interface IProductoService
    {
        Task<List<Producto>> Lista(string buscar = "");
        Task<string> Crear(Producto producto);
        Task<string> Editar(Producto producto);
    }
}