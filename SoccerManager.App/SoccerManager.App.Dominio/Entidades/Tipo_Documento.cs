using System;
namespace SoccerManager.App.Dominio
{
    public class Tipo_Documento
    {
        //Registro_Civil,
        //Tarjeta_de_Identidad,
        //Cedula_de_Ciudadania,
        //Pasaporte,
        //Cedula_Extranjera

        public int Id { get; set; }
        public string Nombre { get; set;}
        public string Abreviatura { get; set;}
    }
}