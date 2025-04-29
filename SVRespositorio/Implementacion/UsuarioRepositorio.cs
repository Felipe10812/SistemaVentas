using Microsoft.Data.SqlClient;
using SVRespositorio.DB;
using SVRespositorio.Entities;
using SVRespositorio.Interfaces;
using System.Data;

namespace SVRespositorio.Implementacion
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly Conexion _conexion;

        public UsuarioRepositorio(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Usuario>> Lista(string buscar = "")
        {
            List<Usuario> lista = new List<Usuario>();
            using (var con = _conexion.obtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaUsuarios", con);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Usuario
                        {
                            IdUsuario = dr.GetInt32(dr.GetOrdinal("IdUsuario")),
                            RefRol = new Rol
                            {
                                IdRol = Convert.ToInt32(dr["IdRol"]),
                                Nombre = dr.GetString(dr.GetOrdinal("Nombre"))
                            },
                            Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                            ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                            ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                            Correo = dr.GetString(dr.GetOrdinal("Correo")),
                            NombreUsuario = dr.GetString(dr.GetOrdinal("NombreUsuario")),
                            Clave = dr.GetString(dr.GetOrdinal("Clave")),
                            ResetearClave = dr.GetBoolean(dr.GetOrdinal("ResetearClave")),
                            Activo = dr.GetBoolean(dr.GetOrdinal("Activo"))
                        });
                    }
                }
            }
            return lista;
        }

        public async Task<string> Crear(Usuario usuario)
        {
            string respuesta = "";

            using (var con = _conexion.obtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_crearUsuario", con);

                // @IdRol
                cmd.Parameters.AddWithValue("@IdRol", usuario.RefRol.IdRol);

                // @Nombre
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);

                // @ApellidoPaterno 
                cmd.Parameters.AddWithValue("@ApellidoPaterno", usuario.ApellidoPaterno);

                // @ApellidoMaterno 
                cmd.Parameters.AddWithValue("@ApellidoMaterno", usuario.ApellidoMaterno);

                // @Correo 
                cmd.Parameters.AddWithValue("@Correo", usuario.Correo);

                // @NombreUsuario 
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);

                // @Clave
                cmd.Parameters.AddWithValue("@Clave", usuario.Clave);

                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }
            }
            return respuesta;
        }

        public async Task<string> Editar(Usuario usuario)
        {
            string respuesta = "";

            using (var con = _conexion.obtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarUsuario", con);

                cmd.Parameters.AddWithValue("@IdRol", usuario.IdUsuario);
                cmd.Parameters.AddWithValue("@IdRol", usuario.RefRol.IdRol);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", usuario.ApellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", usuario.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@Activo", usuario.Activo);

                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }
            }
            return respuesta;
        }
    }
}