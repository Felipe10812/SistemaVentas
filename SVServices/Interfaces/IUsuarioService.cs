using SVRespositorio.Entities;

namespace SVServices.Interfaces
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> Lista(string buscar = "");
        Task<string> Crear(Usuario usuario);
        Task<string> Editar(Usuario usuario);
    }
}