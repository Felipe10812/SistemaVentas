using SVRespositorio.Entities;

namespace SVRespositorio.Interfaces
{
    public interface ICategoriaRepositorio
    {
        Task<List<Categoria>> Lista(string buscar = "");
        Task<string> Crear(Categoria categoria);
        Task<string> Editar(Categoria categoria);
    }
}