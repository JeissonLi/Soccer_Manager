using System;
using SoccerManager.App.Dominio;
using SoccerManager.App.Persistencia;

namespace SoccerManager.App.Consola
{
    class Program
    {
        private static IRepositorios _repoPersona = new Repositorios(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPersona();
            //BuscarPersona(1);

        }

        private static void  AddPersona()
        {
            var persona = new Persona
            {
                Nombre = "Nicolay",
                Apellido = "Perez",
                Correo = "Org@gmail.com",
                Num_Documento = "154168486",
                Telefono = "31545454544",
                Fecha_Nacimiento = new DateTime(2002, 04, 12),
                
                //Tipo_Documento ="Cedula de Ciudadania",
                //Genero = "Masculino",
                //Ciudad = "Bogota",
                //Perfil ="Organizador"
            };
            _repoPersona.AddPersona(persona);
        }
        private static void BuscarPersona(int IdPersona)
        {
            var persona = _repoPersona.GetPersona(IdPersona);
            Console.WriteLine(persona.Nombre+" "+persona.Apellido);
        }
    }
}
