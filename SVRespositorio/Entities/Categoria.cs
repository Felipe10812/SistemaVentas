namespace SVRespositorio.Entities
{
    public class Categoria
    {
        //IdCategoria	Nombre	IdMedida	Activo
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public Medida RefIdMedida { get; set; }
        public bool Activo { get; set; }
    }
}