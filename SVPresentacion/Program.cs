using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SVPresentacion.Formularios;
using SVRespositorio;
using SVServices;

namespace SVPresentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();

            var formService = host.Services.GetRequiredService<frmNegocio>();

            Application.Run(formService);
        }

        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                }).ConfigureServices((context, services) =>
                {
                    services.DependenciasRepositorioRegistro();
                    services.DependenciasServiciosRegistro();

                    services.AddTransient<frmProducto>();
                    services.AddTransient<frmCategoria>();
                    services.AddTransient<frmNegocio>();
                });
    }
}