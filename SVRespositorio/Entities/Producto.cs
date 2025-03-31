namespace SVRespositorio.Entities
{
    public class Producto
    {
        // IdProducto
        public int IdProducto { get; set; }

        // IdCategoria
        public Categoria RefIdCategoria { get; set; }

        // Codigo
        public string Codigo { get; set; }

        // Descripcion
        public string Descripcion { get; set; }
        
        // PrecioCompra
        public decimal PrecioCompra { get; set; }

        // PrecioVenta
        public decimal PrecioVenta { get; set; }

        // Cantidad
        public decimal Cantidad { get; set; }

        // Activo
        public bool Activo { get; set; }
    }
}