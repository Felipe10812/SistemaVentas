using Microsoft.Extensions.DependencyInjection;
using SVRespositorio.DB;
using SVRespositorio.Implementacion;
using SVRespositorio.Interfaces;

namespace SVRespositorio
{
    public static class DependencyInjection
    {
        public static void DependenciasRepositorioRegistro(this IServiceCollection services)
        {
            services.AddSingleton<Conexion>();
            services.AddTransient<IMedidaRepositorio, MedidaRepositorio>();
            services.AddTransient<ICategoriaRepositorio, CategoriaRepositorio>();
            services.AddTransient<IProductoRepositorio, ProductoRepositorio>();
            services.AddTransient<INegocioRepositorio, NegocioRepositorio>();
        }
    }
}