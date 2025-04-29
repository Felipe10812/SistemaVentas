using Microsoft.Data.SqlClient;
using SVRespositorio.DB;
using SVRespositorio.Entities;
using SVRespositorio.Interfaces;
using System.Data;

namespace SVRespositorio.Implementacion
{
    public class RolRepositorio: IRolRepositorio
    {
        private readonly Conexion _conexion;

        public RolRepositorio(Conexion conexion)
        {
            _conexion = conexion;
        }
        public async Task<List<Rol>> Lista()
        {
            List<Rol> lista = new List<Rol>();
            using (var con = _conexion.obtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaRol", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Rol
                        {
                            IdRol = dr.GetInt32(dr.GetOrdinal("IdRol")),
                            Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                        });
                    }
                }
            }
            return lista;
        }
    }
}