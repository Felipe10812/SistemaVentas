using Microsoft.Data.SqlClient;
using SVRespositorio.DB;
using SVRespositorio.Entities;
using SVRespositorio.Interfaces;
using System.Data;

namespace SVRespositorio.Implementacion
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly Conexion _conexion;

        public CategoriaRepositorio(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Categoria>> Lista(string buscar = "")
        {
            List<Categoria> lista = new List<Categoria>();
            using (var con = _conexion.obtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaCategoria", con);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Categoria
                        {
                            IdCategoria = dr.GetInt32(dr.GetOrdinal("IdCategoria")),
                            Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                            Activo = dr.GetBoolean(dr.GetOrdinal("Activo")),
                            RefIdMedida = new Medida
                            {
                                IdMedida = dr.GetInt32(dr.GetOrdinal("IdMedida")),
                                Nombre = dr.GetString(dr.GetOrdinal("NombreMedida")),
                            }
                        });
                    }
                }
            }
            return lista;
        }

        public async Task<string> Crear(Categoria categoria)
        {
            string respuesta = "";

            using (var con = _conexion.obtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_crearCategoria", con);

                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@IdMedida", categoria.RefIdMedida.IdMedida);
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

        public async Task<string> Editar(Categoria categoria)
        {
            string respuesta = "";

            using (var con = _conexion.obtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarCategoria", con);

                cmd.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@IdMedida", categoria.RefIdMedida.IdMedida);
                cmd.Parameters.AddWithValue("@Activo", categoria.Activo);
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