using SVRespositorio.Entities;
using SVRespositorio.Interfaces;
using SVServices.Interfaces;

namespace SVServices.Implementacion
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        public CategoriaService(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        public async Task<List<Categoria>> Lista(string buscar = "")
        {
            return await _categoriaRepositorio.Lista(buscar);
        }

        public async Task<string> Crear(Categoria categoria)
        {
            return await _categoriaRepositorio.Crear(categoria);
        }

        public async Task<string> Editar(Categoria categoria)
        {
            return await _categoriaRepositorio.Editar(categoria);
        }
    }
}