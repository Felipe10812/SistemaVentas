namespace SVRespositorio.Entities
{
    public class Medida
    {
        //IdMedida Nombre  Abreviatura Equivalencia  Valor
        public int IdMedida { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public string Equivalencia { get; set; }
        public int Valor { get; set; }
    }
}