using SVRespositorio.Entities;

namespace SVServices.Interfaces
{
    public interface ICategoriaService
    {
        Task<List<Categoria>> Lista(string buscar = "");
        Task<string> Crear(Categoria categoria);
        Task<string> Editar(Categoria categoria);
    }
}