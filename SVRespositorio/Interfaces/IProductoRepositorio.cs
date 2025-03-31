using SVRespositorio.Entities;

namespace SVRespositorio.Interfaces
{
    public interface IProductoRepositorio
    {
        Task<List<Producto>> Lista(string buscar = "");
        Task<string> Crear(Producto producto);
        Task<string> Editar(Producto producto);
    }
}