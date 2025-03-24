using Microsoft.Data.SqlClient;
using SVRespositorio.DB;
using SVRespositorio.Entities;
using SVRespositorio.Interfaces;
using System.Data;

namespace SVRespositorio.Implementacion
{
    public class MedidaRepositorio : IMedidaRepositorio
    {
        private readonly Conexion _conexion;

        public MedidaRepositorio(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Medida>> Lista()
        {
            List<Medida> lista = new List<Medida>();
            using (var con = _conexion.obtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaMedida", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Medida
                        {
                            IdMedida = dr.GetInt32(dr.GetOrdinal("IdMedida")),
                            Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                            Abreviatura = dr.GetString(dr.GetOrdinal("Abreviatura")),
                            Equivalencia = dr.GetString(dr.GetOrdinal("Equivalencia")),
                            Valor = dr.GetDouble(dr.GetOrdinal("Valor"))
                        });
                    }
                }
            }
            return lista;
        }
    }
}