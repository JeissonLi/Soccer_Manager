using System;
namespace SoccerManager.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public string Correo { get; set;}
        public string Num_Documento { get; set; }
        public string Telefono { get; set;}
        public DateTime Fecha_Nacimiento { get; set; }
        
        public Tipo_Documento tipo_documento { get; set;}
        public Genero genero { get; set; }        
        public Ciudad ciudad { get; set;} 
        public Perfil perfil { get; set;}         

    }
}