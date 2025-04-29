namespace SVRespositorio.Entities
{
    public class Usuario
    {
        //IdUsuario
        public int IdUsuario { get; set; }

        //IdRol
        public Rol RefRol { get; set; }

        //Nombre
        public string Nombre { get; set; }

        //ApellidoPaterno
        public string ApellidoPaterno { get; set; }

        //ApellidoMaterno
        public string ApellidoMaterno { get; set; }

        //Correo
        public string Correo { get; set; }

        //NombreUsuario
        public string NombreUsuario { get; set; }

        //Clave
        public string Clave { get; set; }

        //ResetearClave
        public bool ResetearClave { get; set; }

        //Activo
        public bool Activo { get; set; }
    }
}