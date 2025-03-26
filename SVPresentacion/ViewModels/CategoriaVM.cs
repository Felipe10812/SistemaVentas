
namespace SVPresentacion.ViewModels
{
    public class CategoriaVM
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public int IdMedida { get; set; }
        public string Medida { get; set; }
        public bool Activo { get; set; }

        // Puede que sea necesario cambiarlo en el futuro
        public string Habilitado { get; set; }
    }
}