using Microsoft.Extensions.DependencyInjection;
using SVServices.Implementacion;
using SVServices.Interfaces;

namespace SVServices
{
    public static class DependencyInjection
    {
        public static void DependenciasServiciosRegistro(this IServiceCollection services)
        {
            services.AddTransient<IMedidaService, MedidaService>();
            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<IProductoService, ProductoService>();
        }
    }
}