using SVRespositorio.Entities;

namespace SVRespositorio.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<Usuario>> Lista(string buscar = "");
        Task<string> Crear(Usuario usuario);
        Task<string> Editar(Usuario usuario);
    }
}