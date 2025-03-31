using Microsoft.Data.SqlClient;
using SVRespositorio.DB;
using SVRespositorio.Entities;
using SVRespositorio.Interfaces;
using System.Data;

namespace SVRespositorio.Implementacion
{
    public class ProductoRepositorio: IProductoRepositorio
    {
        private readonly Conexion _conexion;

        public ProductoRepositorio(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Producto>> Lista(string buscar = "")
        {
            List<Producto> lista = new List<Producto>();
            using (var con = _conexion.obtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaProductos", con);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Producto
                        {
                            IdProducto = dr.GetInt32(dr.GetOrdinal("IdProducto")),
                            RefIdCategoria = new Categoria
                            {
                                IdCategoria = dr.GetInt32(dr.GetOrdinal("IdCategoria")),
                                Nombre = dr.GetString(dr.GetOrdinal("NombreCategoria")),
                            },
                            Codigo = dr.GetString(dr.GetOrdinal("Codigo")),
                            Descripcion = dr.GetString(dr.GetOrdinal("Nombre")),
                            PrecioCompra = dr.GetDecimal(dr.GetOrdinal("PrecioCompra")),
                            PrecioVenta = dr.GetDecimal(dr.GetOrdinal("PrecioVenta")),
                            Cantidad = dr.GetDecimal(dr.GetOrdinal("Cantidad")),
                            Activo = dr.GetBoolean(dr.GetOrdinal("Activo")),
                        });
                    }
                }
            }
            return lista;
        }

        public async Task<string> Crear(Producto producto)
        {
            string respuesta = "";

            using (var con = _conexion.obtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_crearProducto", con);

                cmd.Parameters.AddWithValue("@IdCategoria", producto.RefIdCategoria.IdCategoria);
                cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
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

        public async Task<string> Editar(Producto producto)
        {
            string respuesta = "";

            using (var con = _conexion.obtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarProducto", con);

                cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
                cmd.Parameters.AddWithValue("@IdCategoria", producto.RefIdCategoria.IdCategoria);
                cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                cmd.Parameters.AddWithValue("@Activo", producto.Activo);
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