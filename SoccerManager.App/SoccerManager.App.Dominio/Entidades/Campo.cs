using System;
using System.Threading;

namespace SoccerManager.App.Dominio
{
    public class Campo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha_Horario_Inicial { get; set; }
        public DateTime Fecha_Horario_Final { get; set; }

    }
}