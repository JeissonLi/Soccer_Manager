using System;
namespace SoccerManager.App.Dominio
{
    public class Arbitro
    {
        public int Id { get; set; }        
        public string Certificado { get;set;}        
        
        public Persona persona { get; set; }

    }
}