using Microsoft.Data.SqlClient;
using SVRespositorio.DB;
using SVRespositorio.Entities;
using SVRespositorio.Interfaces;
using System.Data;

namespace SVRespositorio.Implementacion
{
    public class NegocioRepositorio : INegocioRepositorio
    {
        private readonly Conexion _conexion;

        public NegocioRepositorio(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<Negocio> Obtener()
        {
            Negocio objeto = new Negocio();
            using (var con = _conexion.obtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaNegocio", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        objeto = new Negocio()
                        {
                            RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
                            RFC = dr.GetString(dr.GetOrdinal("RFC")),
                            Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                            Celular = dr.GetString(dr.GetOrdinal("Celular")),
                            Correo = dr.GetString(dr.GetOrdinal("Correo")),
                            SimboloMoneda = dr.GetString(dr.GetOrdinal("SimboloMoneda")),
                            NombreLogo = dr.GetString(dr.GetOrdinal("NombreLogo")),
                            URLLogo = dr.GetString(dr.GetOrdinal("URLLogo"))
                        };
                    }
                }
            }
            return objeto;
        }

        public async Task Editar(Negocio negocio)
        {
            using (var con = _conexion.obtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarNegocio", con);

                cmd.Parameters.AddWithValue("@RazonSocial", negocio.RazonSocial);
                cmd.Parameters.AddWithValue("@RFC", negocio.RFC);
                cmd.Parameters.AddWithValue("@Direccion", negocio.Direccion);
                cmd.Parameters.AddWithValue("@Celular", negocio.Celular);
                cmd.Parameters.AddWithValue("@Correo", negocio.Correo);
                cmd.Parameters.AddWithValue("@SimboloMoneda", negocio.SimboloMoneda);
                cmd.Parameters.AddWithValue("@NombreLogo", negocio.NombreLogo);
                cmd.Parameters.AddWithValue("@URLLogo", negocio.URLLogo);
                cmd.Parameters.AddWithValue("@IdNegocio", negocio.IdNegocio);
                //cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}