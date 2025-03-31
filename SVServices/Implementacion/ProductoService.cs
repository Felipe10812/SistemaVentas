using SVRespositorio.Entities;
using SVRespositorio.Interfaces;
using SVServices.Interfaces;

namespace SVServices.Implementacion
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepositorio _productoRepositorio;
        public ProductoService(IProductoRepositorio productoRepositorio)
        {
            _productoRepositorio = productoRepositorio;
        }

        public async Task<List<Producto>> Lista(string buscar = "")
        {
            return await _productoRepositorio.Lista(buscar);
        }

        public async Task<string> Crear(Producto producto)
        {
            return await _productoRepositorio.Crear(producto);
        }

        public async Task<string> Editar(Producto producto)
        {
            return await _productoRepositorio.Editar(producto);
        }
    }
}