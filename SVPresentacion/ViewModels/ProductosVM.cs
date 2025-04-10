using System.ComponentModel;

namespace SVPresentacion.ViewModels
{
    public class ProductosVM
    {
        public int IdProducto { get; set; }

        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public int IdCategoria { get; set; }

        [DisplayName("Nombre Categoria")]
        public string Categoria { get; set; }

        [DisplayName("Precio Compra")]
        public string PrecioCompra { get; set; }

        [DisplayName("Precio Venta")]
        public string PrecioVenta { get; set; }

        public decimal Cantidad { get; set; } 

        public bool Activo { get; set; }

        public string Habilitado { get; set; }
    }
}