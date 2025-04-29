using SVRespositorio.Entities;
using SVRespositorio.Interfaces;
using SVServices.Interfaces;

namespace SVServices.Implementacion
{
    public class UsuarioService: IUsuarioService
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioService(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<List<Usuario>> Lista(string buscar = "")
        {
            return await _usuarioRepositorio.Lista(buscar);
        }

        public async Task<string> Crear(Usuario usuario)
        {
            return await _usuarioRepositorio.Crear(usuario);
        }

        public async Task<string> Editar(Usuario usuario)
        {
            return await _usuarioRepositorio.Editar(usuario);
        }
    }
}