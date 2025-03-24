using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SVRespositorio.DB
{
    public class Conexion
    {
        private readonly IConfiguration _configuracion;
        private readonly string _cadenaConexion;

        public Conexion(IConfiguration configuracion)
        {
            _configuracion = configuracion;
            _cadenaConexion = _configuracion.GetConnectionString("CadenaSQL")!;
        }

        public SqlConnection obtenerSQLConexion()
        {
            return new SqlConnection(_cadenaConexion);
        }
    }
}