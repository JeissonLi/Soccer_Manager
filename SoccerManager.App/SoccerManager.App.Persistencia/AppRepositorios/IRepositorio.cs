using System.Collections.Generic;
using SoccerManager.App.Dominio;

namespace SoccerManager.App.Persistencia
{
    public interface IRepositorios
    {
        //CRUD PERSONA
        IEnumerable<Persona> GetAllPersonas();

        Persona AddPersona(Persona persona);

        Persona UpdatePersona(Persona persona);

        void DeletePersona(int IdPersona);
        
        Persona GetPersona(int? IdPersona);
        //========================================================================================
        //CRUD CAMPOS

        IEnumerable<Campo> GetAllCampos();

        Campo AddCampo(Campo campo);

        Campo UpdateCampo(Campo campo);

        void DeleteCampo(int IdCampo);

        Campo GetCampo(int? IdCampo);
        //========================================================================================
    }
}