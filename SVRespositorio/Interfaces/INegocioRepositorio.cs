using SVRespositorio.Entities;

namespace SVRespositorio.Interfaces
{
    public interface INegocioRepositorio
    {
        Task<Negocio> Obtener();
        //Task<string> Crear(Negocio negocio);
        Task Editar(Negocio negocio);
    }
}